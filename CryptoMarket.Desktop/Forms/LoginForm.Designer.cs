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
            SignInLabel = new Label();
            SignUpLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            LoginErrorLabel = new Label();
            PasswordErrorLabel = new Label();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(692, 306);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(200, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(692, 349);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(200, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Location = new Point(764, 381);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(43, 15);
            SignInLabel.TabIndex = 2;
            SignInLabel.Text = "Sign in";
            SignInLabel.Click += SignInLabel_Click;
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
            label1.Location = new Point(748, 289);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(748, 331);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "Enter Password";
            // 
            // LoginErrorLabel
            // 
            LoginErrorLabel.AutoSize = true;
            LoginErrorLabel.BackColor = Color.White;
            LoginErrorLabel.ForeColor = Color.Red;
            LoginErrorLabel.Location = new Point(898, 309);
            LoginErrorLabel.Name = "LoginErrorLabel";
            LoginErrorLabel.Size = new Size(60, 15);
            LoginErrorLabel.TabIndex = 13;
            LoginErrorLabel.Text = "ErrorLabel";
            LoginErrorLabel.Visible = false;
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.AutoSize = true;
            PasswordErrorLabel.BackColor = Color.White;
            PasswordErrorLabel.ForeColor = Color.Red;
            PasswordErrorLabel.Location = new Point(898, 351);
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(60, 15);
            PasswordErrorLabel.TabIndex = 14;
            PasswordErrorLabel.Text = "ErrorLabel";
            PasswordErrorLabel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 759);
            Controls.Add(PasswordErrorLabel);
            Controls.Add(LoginErrorLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SignUpLabel);
            Controls.Add(SignInLabel);
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
        private Label SignInLabel;
        private Label SignUpLabel;
        private Label label1;
        private Label label2;
        private Label LoginErrorLabel;
        private Label PasswordErrorLabel;
    }
}