namespace CryptoMarket.Desktop.Forms
{
    partial class RegistrationForm
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
            LoginLabel = new Label();
            LoginTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            EmailLabel = new Label();
            SaveRegistration = new Button();
            loginErrorLabel = new Label();
            emailErrorLabel = new Label();
            passwordErrorLabel = new Label();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(325, 89);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(67, 15);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Enter Login";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(325, 107);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(250, 23);
            LoginTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(325, 157);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(250, 23);
            EmailTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(325, 190);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Enter Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(325, 208);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(250, 23);
            PasswordTextBox.TabIndex = 5;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(325, 139);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(66, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Enter Email";
            // 
            // SaveRegistration
            // 
            SaveRegistration.FlatAppearance.BorderSize = 0;
            SaveRegistration.FlatStyle = FlatStyle.Flat;
            SaveRegistration.Location = new Point(375, 369);
            SaveRegistration.Name = "SaveRegistration";
            SaveRegistration.Size = new Size(150, 30);
            SaveRegistration.TabIndex = 6;
            SaveRegistration.Text = "Save";
            SaveRegistration.UseVisualStyleBackColor = true;
            SaveRegistration.Click += SaveRegistration_Click;
            // 
            // loginErrorLabel
            // 
            loginErrorLabel.AutoSize = true;
            loginErrorLabel.BackColor = Color.White;
            loginErrorLabel.ForeColor = Color.Red;
            loginErrorLabel.Location = new Point(581, 110);
            loginErrorLabel.Name = "loginErrorLabel";
            loginErrorLabel.Size = new Size(60, 15);
            loginErrorLabel.TabIndex = 7;
            loginErrorLabel.Text = "ErrorLabel";
            loginErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.BackColor = Color.White;
            emailErrorLabel.ForeColor = Color.Red;
            emailErrorLabel.Location = new Point(581, 160);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(60, 15);
            emailErrorLabel.TabIndex = 8;
            emailErrorLabel.Text = "ErrorLabel";
            emailErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.BackColor = Color.White;
            passwordErrorLabel.ForeColor = Color.Red;
            passwordErrorLabel.Location = new Point(581, 210);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(60, 15);
            passwordErrorLabel.TabIndex = 9;
            passwordErrorLabel.Text = "ErrorLabel";
            passwordErrorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 411);
            Controls.Add(passwordErrorLabel);
            Controls.Add(emailErrorLabel);
            Controls.Add(loginErrorLabel);
            Controls.Add(SaveRegistration);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(LoginLabel);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label EmailLabel;
        private Button SaveRegistration;
        private Label loginErrorLabel;
        private Label emailErrorLabel;
        private Label passwordErrorLabel;
    }
}