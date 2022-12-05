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
            // Запись данных в базу данных + проверка
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
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
