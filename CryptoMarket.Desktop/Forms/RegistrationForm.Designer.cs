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
			this.LoginLabel = new System.Windows.Forms.Label();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.SaveRegistration = new System.Windows.Forms.Button();
			this.loginErrorLabel = new System.Windows.Forms.Label();
			this.emailErrorLabel = new System.Windows.Forms.Label();
			this.passwordErrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(325, 101);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(74, 17);
			this.LoginLabel.TabIndex = 0;
			this.LoginLabel.Text = "Enter Login";
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(325, 121);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(250, 25);
			this.LoginTextBox.TabIndex = 1;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(325, 178);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(250, 25);
			this.EmailTextBox.TabIndex = 3;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(325, 215);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(98, 17);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "Enter Password";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(325, 236);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(250, 25);
			this.PasswordTextBox.TabIndex = 5;
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(325, 158);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(73, 17);
			this.EmailLabel.TabIndex = 4;
			this.EmailLabel.Text = "Enter Email";
			// 
			// SaveRegistration
			// 
			this.SaveRegistration.FlatAppearance.BorderSize = 0;
			this.SaveRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveRegistration.Location = new System.Drawing.Point(375, 418);
			this.SaveRegistration.Name = "SaveRegistration";
			this.SaveRegistration.Size = new System.Drawing.Size(150, 34);
			this.SaveRegistration.TabIndex = 6;
			this.SaveRegistration.Text = "Save";
			this.SaveRegistration.UseVisualStyleBackColor = true;
			// 
			// loginErrorLabel
			// 
			this.loginErrorLabel.AutoSize = true;
			this.loginErrorLabel.BackColor = System.Drawing.Color.White;
			this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.loginErrorLabel.Location = new System.Drawing.Point(581, 125);
			this.loginErrorLabel.Name = "loginErrorLabel";
			this.loginErrorLabel.Size = new System.Drawing.Size(69, 17);
			this.loginErrorLabel.TabIndex = 7;
			this.loginErrorLabel.Text = "ErrorLabel";
			this.loginErrorLabel.Visible = false;
			// 
			// emailErrorLabel
			// 
			this.emailErrorLabel.AutoSize = true;
			this.emailErrorLabel.BackColor = System.Drawing.Color.White;
			this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.emailErrorLabel.Location = new System.Drawing.Point(581, 181);
			this.emailErrorLabel.Name = "emailErrorLabel";
			this.emailErrorLabel.Size = new System.Drawing.Size(69, 17);
			this.emailErrorLabel.TabIndex = 8;
			this.emailErrorLabel.Text = "ErrorLabel";
			this.emailErrorLabel.Visible = false;
			// 
			// passwordErrorLabel
			// 
			this.passwordErrorLabel.AutoSize = true;
			this.passwordErrorLabel.BackColor = System.Drawing.Color.White;
			this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.passwordErrorLabel.Location = new System.Drawing.Point(581, 238);
			this.passwordErrorLabel.Name = "passwordErrorLabel";
			this.passwordErrorLabel.Size = new System.Drawing.Size(69, 17);
			this.passwordErrorLabel.TabIndex = 9;
			this.passwordErrorLabel.Text = "ErrorLabel";
			this.passwordErrorLabel.Visible = false;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 466);
			this.Controls.Add(this.passwordErrorLabel);
			this.Controls.Add(this.emailErrorLabel);
			this.Controls.Add(this.loginErrorLabel);
			this.Controls.Add(this.SaveRegistration);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.LoginLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "RegistrationForm";
			this.Text = "RegistrationForm";
			this.ResumeLayout(false);
			this.PerformLayout();

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