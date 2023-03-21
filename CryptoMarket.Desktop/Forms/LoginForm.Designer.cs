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
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUpLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            loginErrorLabel = new Label();
            passwordErrorLabel = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(650, 326);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(300, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(650, 370);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(300, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpLabel.Location = new Point(12, 735);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(48, 15);
            SignUpLabel.TabIndex = 3;
            SignUpLabel.Text = "Sign Up";
            SignUpLabel.Click += SignUpLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(650, 308);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(650, 352);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter Password";
            // 
            // loginErrorLabel
            // 
            loginErrorLabel.AutoSize = true;
            loginErrorLabel.BackColor = Color.White;
            loginErrorLabel.ForeColor = Color.Red;
            loginErrorLabel.Location = new Point(956, 329);
            loginErrorLabel.Name = "loginErrorLabel";
            loginErrorLabel.Size = new Size(60, 15);
            loginErrorLabel.TabIndex = 13;
            loginErrorLabel.Text = "ErrorLabel";
            loginErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.BackColor = Color.White;
            passwordErrorLabel.ForeColor = Color.Red;
            passwordErrorLabel.Location = new Point(956, 373);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(60, 15);
            passwordErrorLabel.TabIndex = 14;
            passwordErrorLabel.Text = "ErrorLabel";
            passwordErrorLabel.Visible = false;
            // 
            // LoginButton
            // 
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Location = new Point(650, 399);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(300, 23);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "Sign In";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 759);
            Controls.Add(LoginButton);
            Controls.Add(passwordErrorLabel);
            Controls.Add(loginErrorLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SignUpLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
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