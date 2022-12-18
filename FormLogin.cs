using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Coursework_2kurs
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private class User
        {
            string Login { get; }
            string Password { get; }

            public User(string login, string password)
            {
                Login = login;
                Password = password;
            }
            public bool CheckUser() 
            {
                string database = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Database_users.db";
                SQLiteConnection DB = new SQLiteConnection(@"Data Source=" + database + "; Version=3;");
                DB.Open();
                SQLiteCommand CMD = DB.CreateCommand();
                if ((Login != null) & (Password != null))
                {
                    CMD.CommandText = "SELECT Login from Users where Login=@Login";
                    CMD.Parameters.Add("@Login", DbType.String).Value = Login;
                    SQLiteDataReader SQL_Login = CMD.ExecuteReader();

                    bool FoundLogin = false;
                    while (SQL_Login.Read())
                    {
                        FoundLogin = SQL_Login.HasRows;
                    }
                    SQL_Login.Close();

                    if (FoundLogin)
                    {
                        CMD.CommandText = "SELECT Login, Password from Users where Login=@Login";
                        CMD.Parameters.Add("@Login", DbType.String).Value = Login;
                        SQLiteDataReader SQL_Password = CMD.ExecuteReader();
                        string Founded_Password = "";
                        while (SQL_Password.Read()) 
                        {
                            Founded_Password = Convert.ToString(SQL_Password["Password"]);
                        }
                        SQL_Password.Close();
                        if (Founded_Password == Password)
                        {
                            DB.Close();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введен пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DB.Close();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильно написан логин или пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DB.Close();
                        return false;
                    }
                } 
                else
                {
                    MessageBox.Show("Заполните все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DB.Close();
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
