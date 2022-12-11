namespace Coursework_2kurs
{
    partial class FormRegistation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass_repeated = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Password_repeated = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button_RegisterApprove = new System.Windows.Forms.Button();
            this.button_Сancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label_login.Location = new System.Drawing.Point(3, 120);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(194, 25);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Имя пользователя";
            // 
            // label_pass_repeated
            // 
            this.label_pass_repeated.AutoSize = true;
            this.label_pass_repeated.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label_pass_repeated.Location = new System.Drawing.Point(5, 220);
            this.label_pass_repeated.Name = "label_pass_repeated";
            this.label_pass_repeated.Size = new System.Drawing.Size(192, 25);
            this.label_pass_repeated.TabIndex = 2;
            this.label_pass_repeated.Text = "Повторите пароль";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label_pass.Location = new System.Drawing.Point(111, 169);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(86, 25);
            this.label_pass.TabIndex = 3;
            this.label_pass.Text = "Пароль";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(195, 120);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(235, 26);
            this.textBox_Login.TabIndex = 4;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(195, 170);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(235, 26);
            this.textBox_Password.TabIndex = 5;
            // 
            // textBox_Password_repeated
            // 
            this.textBox_Password_repeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password_repeated.Location = new System.Drawing.Point(195, 220);
            this.textBox_Password_repeated.Name = "textBox_Password_repeated";
            this.textBox_Password_repeated.PasswordChar = '*';
            this.textBox_Password_repeated.Size = new System.Drawing.Size(235, 26);
            this.textBox_Password_repeated.TabIndex = 6;
            this.textBox_Password_repeated.TextChanged += new System.EventHandler(this.textBox_Password_repeated_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(436, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.checkBox2.Location = new System.Drawing.Point(436, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 23);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Показать пароль";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button_RegisterApprove
            // 
            this.button_RegisterApprove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button_RegisterApprove.Location = new System.Drawing.Point(195, 290);
            this.button_RegisterApprove.Name = "button_RegisterApprove";
            this.button_RegisterApprove.Size = new System.Drawing.Size(235, 35);
            this.button_RegisterApprove.TabIndex = 9;
            this.button_RegisterApprove.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.button_RegisterApprove.UseVisualStyleBackColor = true;
            this.button_RegisterApprove.Click += new System.EventHandler(this.button_RegisterApprove_Click);
            // 
            // button_Сancel
            // 
            this.button_Сancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.button_Сancel.Location = new System.Drawing.Point(195, 350);
            this.button_Сancel.Name = "button_Сancel";
            this.button_Сancel.Size = new System.Drawing.Size(235, 35);
            this.button_Сancel.TabIndex = 10;
            this.button_Сancel.Text = "ОТМЕНА";
            this.button_Сancel.UseVisualStyleBackColor = true;
            this.button_Сancel.Click += new System.EventHandler(this.button_Сancel_Click);
            // 
            // FormRegistation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.button_Сancel);
            this.Controls.Add(this.button_RegisterApprove);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_Password_repeated);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_pass_repeated);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistation";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormRegistation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pass_repeated;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Password_repeated;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button_RegisterApprove;
        private System.Windows.Forms.Button button_Сancel;
    }
}