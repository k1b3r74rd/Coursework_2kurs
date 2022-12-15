using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_2kurs
{
    public partial class FormRegistation : Form
    {
        public FormRegistation()
        {
            InitializeComponent();
        }

        private void textBox_Password_repeated_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password.Text != textBox_Password_repeated.Text)
            {
                label_pass_repeated.ForeColor = Color.Red;
            }
            else
            {
                label_pass_repeated.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password_repeated.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button_RegisterApprove_Click(object sender, EventArgs e)
        {
            if ((textBox_Login.Text != "") & (textBox_Password.Text != "") & (textBox_Password.Text == textBox_Password_repeated.Text))
            {
                string database = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database_users.db";
                SQLiteConnection DB = new SQLiteConnection(@"Data Source=" + database + "; Version=3;");
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                CMD.CommandText = "SELECT Login from Users where Login=@Login";
                CMD.Parameters.Add("@Login", DbType.String).Value = textBox_Login.Text;
                SQLiteDataReader SQL_reader = CMD.ExecuteReader();

                bool FoundLogin = false;
                while (SQL_reader.Read())
                {
                    FoundLogin = SQL_reader.HasRows;
                }
                SQL_reader.Close();

                if (!FoundLogin) 
                {
                    CMD.CommandText = "INSERT into Users(Login, Password) values(@Login, @Password)";
                    CMD.Parameters.Add("@Login", DbType.String).Value = textBox_Login.Text;
                    CMD.Parameters.Add("@Password", DbType.String).Value = textBox_Password.Text;
                    CMD.ExecuteNonQuery();

                    MessageBox.Show("Регистрация завершена.");
                }
                else
                {
                    MessageBox.Show("Данный логин уже занят. Выберите другой.");
                }
                DB.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля корректно.");
            }
        }

        private void button_Сancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
        }
    }
}
