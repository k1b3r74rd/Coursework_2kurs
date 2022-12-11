using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Coursework_2kurs
{
    public partial class FormLogin : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection("Data Source=G:\\0.PROJECTS\\C#\\TUSUR\\Coursework_2kurs\\Database_users.db; Version=3");

        public FormLogin()
        {
            InitializeComponent();
        }
        public void FormLogin_Load(object sender, EventArgs e)
        {
            DB.Open();
        }

        public void FormLogin_Close(object sender, FormClosingEventArgs e)
        {
            DB.Close();
        }

        public class User
        {
            public string Login { get; }
            public string Password { get; }

            public User(string login, string password)
            {
                Login = login;
                Password = password;
            }
            public bool CheckUser() 
            {
                SQLiteCommand CMD = DB.CreateCommand();
                if ((Login != null) & (Password != null))
                {
                    CMD.CommandText = "SELECT Login from Users where Login=@Login";
                    CMD.Parameters.Add("@Login", DbType.String).Value = Login;
                    SQLiteDataReader SQL = CMD.ExecuteReader();
                    bool HasRows = SQL.HasRows;
                    SQL.Close();

                    if (HasRows)
                    {
                        CMD.CommandText = "SELECT Login, Password from Users where Login=@Login";
                        CMD.Parameters.Add("@Login", DbType.String).Value = Login;
                        SQLiteDataReader SQL2 = CMD.ExecuteReader();
                        if (Convert.ToString(SQL2["Password"]) == Password)
                        {
                            SQL2.Close();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введен пароль.");
                            SQL2.Close();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильно написан логин или пароль.");
                        return false;
                    }
                } 
                else
                {
                    MessageBox.Show("Заполните все поля");
                    return false;
                }
            }
        }

        private void button_auth_Click(object sender, EventArgs e)
        {
            if (new User(textBox_Login.Text, textBox_Password.Text).CheckUser())
            {
                this.Hide();
                FormMainFunc formMainFunc = new FormMainFunc();
                formMainFunc.Closed += (s, args) => this.Close();
                formMainFunc.Show();
            }
            else
            {
                return;
            }
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistation formRegistation = new FormRegistation();
            formRegistation.Closed += (s, args) => this.Close();
            formRegistation.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
