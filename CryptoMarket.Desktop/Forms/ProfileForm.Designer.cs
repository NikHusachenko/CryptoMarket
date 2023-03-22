namespace CryptoMarket.Desktop.Forms
{
    partial class ProfileForm
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
            label1 = new Label();
            LoginTextBox = new TextBox();
            EmailTextBox = new TextBox();
            label2 = new Label();
            NewPasswordTextBox = new TextBox();
            label3 = new Label();
            OldPasswordTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CancelBtn = new Label();
            ChangePasswordBox = new GroupBox();
            NewPasswordErrorLabel = new Label();
            OldPasswordErrorLabel = new Label();
            ChangePasswordLabel = new Label();
            LoginErrorLabel = new Label();
            EmailErrorLabel = new Label();
            ChangePasswordBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 126);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(292, 144);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(200, 23);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.TextChanged += LoginTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(292, 196);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(200, 23);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // NewPasswordTextBox
            // 
            NewPasswordTextBox.Location = new Point(152, 109);
            NewPasswordTextBox.Name = "NewPasswordTextBox";
            NewPasswordTextBox.Size = new Size(200, 23);
            NewPasswordTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 92);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "New Password";
            // 
            // OldPasswordTextBox
            // 
            OldPasswordTextBox.Location = new Point(152, 49);
            OldPasswordTextBox.Name = "OldPasswordTextBox";
            OldPasswordTextBox.Size = new Size(200, 23);
            OldPasswordTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 32);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 4;
            label4.Text = "Old Password";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(-19, 520);
            label5.Name = "label5";
            label5.Size = new Size(800, 2);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.68317F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(686, 528);
            label6.Name = "label6";
            label6.Size = new Size(56, 30);
            label6.TabIndex = 8;
            label6.Text = "Save";
            label6.Click += SaveLabel_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.AutoSize = true;
            CancelBtn.Font = new Font("Segoe UI", 15.68317F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.Location = new Point(24, 528);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(56, 30);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Back";
            CancelBtn.Click += CancelLabel_Click;
            // 
            // ChangePasswordBox
            // 
            ChangePasswordBox.Controls.Add(NewPasswordErrorLabel);
            ChangePasswordBox.Controls.Add(OldPasswordErrorLabel);
            ChangePasswordBox.Controls.Add(OldPasswordTextBox);
            ChangePasswordBox.Controls.Add(label4);
            ChangePasswordBox.Controls.Add(label3);
            ChangePasswordBox.Controls.Add(NewPasswordTextBox);
            ChangePasswordBox.Location = new Point(136, 291);
            ChangePasswordBox.Name = "ChangePasswordBox";
            ChangePasswordBox.Size = new Size(547, 199);
            ChangePasswordBox.TabIndex = 10;
            ChangePasswordBox.TabStop = false;
            // 
            // NewPasswordErrorLabel
            // 
            NewPasswordErrorLabel.AutoSize = true;
            NewPasswordErrorLabel.BackColor = Color.White;
            NewPasswordErrorLabel.ForeColor = Color.Red;
            NewPasswordErrorLabel.Location = new Point(352, 112);
            NewPasswordErrorLabel.Name = "NewPasswordErrorLabel";
            NewPasswordErrorLabel.Size = new Size(60, 15);
            NewPasswordErrorLabel.TabIndex = 15;
            NewPasswordErrorLabel.Text = "ErrorLabel";
            // 
            // OldPasswordErrorLabel
            // 
            OldPasswordErrorLabel.AutoSize = true;
            OldPasswordErrorLabel.BackColor = Color.White;
            OldPasswordErrorLabel.ForeColor = Color.Red;
            OldPasswordErrorLabel.Location = new Point(352, 52);
            OldPasswordErrorLabel.Name = "OldPasswordErrorLabel";
            OldPasswordErrorLabel.Size = new Size(60, 15);
            OldPasswordErrorLabel.TabIndex = 14;
            OldPasswordErrorLabel.Text = "ErrorLabel";
            // 
            // ChangePasswordLabel
            // 
            ChangePasswordLabel.AutoSize = true;
            ChangePasswordLabel.ForeColor = SystemColors.ActiveCaption;
            ChangePasswordLabel.Location = new Point(340, 229);
            ChangePasswordLabel.Name = "ChangePasswordLabel";
            ChangePasswordLabel.Size = new Size(101, 15);
            ChangePasswordLabel.TabIndex = 11;
            ChangePasswordLabel.Text = "Change Password";
            ChangePasswordLabel.Click += ChangePasswordLabel_Click;
            // 
            // LoginErrorLabel
            // 
            LoginErrorLabel.AutoSize = true;
            LoginErrorLabel.BackColor = Color.White;
            LoginErrorLabel.ForeColor = Color.Red;
            LoginErrorLabel.Location = new Point(495, 146);
            LoginErrorLabel.Name = "LoginErrorLabel";
            LoginErrorLabel.Size = new Size(60, 15);
            LoginErrorLabel.TabIndex = 12;
            LoginErrorLabel.Text = "ErrorLabel";
            LoginErrorLabel.Visible = false;
            // 
            // EmailErrorLabel
            // 
            EmailErrorLabel.AutoSize = true;
            EmailErrorLabel.BackColor = Color.White;
            EmailErrorLabel.ForeColor = Color.Red;
            EmailErrorLabel.Location = new Point(495, 199);
            EmailErrorLabel.Name = "EmailErrorLabel";
            EmailErrorLabel.Size = new Size(60, 15);
            EmailErrorLabel.TabIndex = 13;
            EmailErrorLabel.Text = "ErrorLabel";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 571);
            Controls.Add(EmailErrorLabel);
            Controls.Add(LoginErrorLabel);
            Controls.Add(ChangePasswordLabel);
            Controls.Add(ChangePasswordBox);
            Controls.Add(CancelBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(LoginTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProfileForm";
            Text = "ProfileForm";
            ChangePasswordBox.ResumeLayout(false);
            ChangePasswordBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LoginTextBox;
        private TextBox EmailTextBox;
        private Label label2;
        private TextBox NewPasswordTextBox;
        private Label label3;
        private TextBox OldPasswordTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label CancelBtn;
        private GroupBox ChangePasswordBox;
        private Label ChangePasswordLabel;
        private Label LoginErrorLabel;
        private Label EmailErrorLabel;
        private Label NewPasswordErrorLabel;
        private Label OldPasswordErrorLabel;
    }
}