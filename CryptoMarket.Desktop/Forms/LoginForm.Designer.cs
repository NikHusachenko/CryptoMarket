namespace CryptoMarket.Desktop.Forms
{
    partial class LoginForm
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
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SignUpLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.loginErrorLabel = new System.Windows.Forms.Label();
			this.passwordErrorLabel = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(650, 369);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(300, 25);
			this.LoginTextBox.TabIndex = 0;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(650, 419);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(300, 25);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// SignUpLabel
			// 
			this.SignUpLabel.AutoSize = true;
			this.SignUpLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignUpLabel.Location = new System.Drawing.Point(12, 833);
			this.SignUpLabel.Name = "SignUpLabel";
			this.SignUpLabel.Size = new System.Drawing.Size(54, 17);
			this.SignUpLabel.TabIndex = 3;
			this.SignUpLabel.Text = "Sign Up";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(650, 349);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(650, 399);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Enter Password";
			// 
			// loginErrorLabel
			// 
			this.loginErrorLabel.AutoSize = true;
			this.loginErrorLabel.BackColor = System.Drawing.Color.White;
			this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.loginErrorLabel.Location = new System.Drawing.Point(956, 373);
			this.loginErrorLabel.Name = "loginErrorLabel";
			this.loginErrorLabel.Size = new System.Drawing.Size(69, 17);
			this.loginErrorLabel.TabIndex = 13;
			this.loginErrorLabel.Text = "ErrorLabel";
			this.loginErrorLabel.Visible = false;
			// 
			// passwordErrorLabel
			// 
			this.passwordErrorLabel.AutoSize = true;
			this.passwordErrorLabel.BackColor = System.Drawing.Color.White;
			this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.passwordErrorLabel.Location = new System.Drawing.Point(956, 423);
			this.passwordErrorLabel.Name = "passwordErrorLabel";
			this.passwordErrorLabel.Size = new System.Drawing.Size(69, 17);
			this.passwordErrorLabel.TabIndex = 14;
			this.passwordErrorLabel.Text = "ErrorLabel";
			this.passwordErrorLabel.Visible = false;
			// 
			// LoginButton
			// 
			this.LoginButton.FlatAppearance.BorderSize = 0;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Location = new System.Drawing.Point(650, 452);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(300, 26);
			this.LoginButton.TabIndex = 15;
			this.LoginButton.Text = "Sign In";
			this.LoginButton.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 860);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.passwordErrorLabel);
			this.Controls.Add(this.loginErrorLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SignUpLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Label SignUpLabel;
        private Label label1;
        private Label label2;
        private Label loginErrorLabel;
        private Label passwordErrorLabel;
        private Button LoginButton;
    }
}