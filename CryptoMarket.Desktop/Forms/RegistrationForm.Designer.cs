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
            LoginErrorLabel = new Label();
            EmailErrorLabel = new Label();
            PasswordErrorLabel = new Label();
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
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(325, 157);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(250, 23);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
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
            PasswordTextBox.Size = new Size(250, 23);
            PasswordTextBox.TabIndex = 5;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
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
            // LoginErrorLabel
            // 
            LoginErrorLabel.AutoSize = true;
            LoginErrorLabel.BackColor = Color.White;
            LoginErrorLabel.ForeColor = Color.Red;
            LoginErrorLabel.Location = new Point(581, 110);
            LoginErrorLabel.Name = "LoginErrorLabel";
            LoginErrorLabel.Size = new Size(60, 15);
            LoginErrorLabel.TabIndex = 7;
            LoginErrorLabel.Text = "ErrorLabel";
            LoginErrorLabel.Visible = false;
            // 
            // EmailErrorLabel
            // 
            EmailErrorLabel.AutoSize = true;
            EmailErrorLabel.BackColor = Color.White;
            EmailErrorLabel.ForeColor = Color.Red;
            EmailErrorLabel.Location = new Point(581, 160);
            EmailErrorLabel.Name = "EmailErrorLabel";
            EmailErrorLabel.Size = new Size(60, 15);
            EmailErrorLabel.TabIndex = 8;
            EmailErrorLabel.Text = "ErrorLabel";
            EmailErrorLabel.Visible = false;
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.AutoSize = true;
            PasswordErrorLabel.BackColor = Color.White;
            PasswordErrorLabel.ForeColor = Color.Red;
            PasswordErrorLabel.Location = new Point(581, 210);
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(60, 15);
            PasswordErrorLabel.TabIndex = 9;
            PasswordErrorLabel.Text = "ErrorLabel";
            PasswordErrorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 411);
            Controls.Add(PasswordErrorLabel);
            Controls.Add(EmailErrorLabel);
            Controls.Add(LoginErrorLabel);
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
        private Label LoginErrorLabel;
        private Label EmailErrorLabel;
        private Label PasswordErrorLabel;
    }
}