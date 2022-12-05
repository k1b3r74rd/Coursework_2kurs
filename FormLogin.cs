using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_2kurs
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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
            public bool CheckUser() // Переделать функцию под SQLite 
            {
                return true;
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
                // Ошибки при авторизации
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
