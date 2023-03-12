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
			this.label1 = new System.Windows.Forms.Label();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.CancelBtn = new System.Windows.Forms.Label();
			this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			this.ChangePasswordBox = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ChangePasswordLabel = new System.Windows.Forms.Label();
			this.LoginErrorLabel = new System.Windows.Forms.Label();
			this.ChangePasswordBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(292, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(292, 163);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(200, 25);
			this.LoginTextBox.TabIndex = 1;
			this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(292, 222);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(200, 25);
			this.EmailTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(293, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Email";
			// 
			// NewPasswordTextBox
			// 
			this.NewPasswordTextBox.Location = new System.Drawing.Point(72, 124);
			this.NewPasswordTextBox.Name = "NewPasswordTextBox";
			this.NewPasswordTextBox.Size = new System.Drawing.Size(200, 25);
			this.NewPasswordTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(117, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "New Password";
			// 
			// OldPasswordTextBox
			// 
			this.OldPasswordTextBox.Location = new System.Drawing.Point(72, 56);
			this.OldPasswordTextBox.Name = "OldPasswordTextBox";
			this.OldPasswordTextBox.Size = new System.Drawing.Size(200, 25);
			this.OldPasswordTextBox.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(117, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Old Password";
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(-19, 589);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(800, 2);
			this.label5.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(686, 598);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 31);
			this.label6.TabIndex = 8;
			this.label6.Text = "Save";
			this.label6.Click += new System.EventHandler(this.SaveLabel_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.AutoSize = true;
			this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 15.68317F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CancelBtn.Location = new System.Drawing.Point(24, 598);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(82, 31);
			this.CancelBtn.TabIndex = 9;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.Click += new System.EventHandler(this.CancelLabel_Click);
			// 
			// sqlCommand1
			// 
			this.sqlCommand1.CommandTimeout = 30;
			this.sqlCommand1.EnableOptimizedParameterBinding = false;
			// 
			// ChangePasswordBox
			// 
			this.ChangePasswordBox.Controls.Add(this.OldPasswordTextBox);
			this.ChangePasswordBox.Controls.Add(this.label4);
			this.ChangePasswordBox.Controls.Add(this.label3);
			this.ChangePasswordBox.Controls.Add(this.NewPasswordTextBox);
			this.ChangePasswordBox.Location = new System.Drawing.Point(223, 330);
			this.ChangePasswordBox.Name = "ChangePasswordBox";
			this.ChangePasswordBox.Size = new System.Drawing.Size(344, 226);
			this.ChangePasswordBox.TabIndex = 10;
			this.ChangePasswordBox.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 8;
			this.label7.Text = "<- Back";
			// 
			// ChangePasswordLabel
			// 
			this.ChangePasswordLabel.AutoSize = true;
			this.ChangePasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.ChangePasswordLabel.Location = new System.Drawing.Point(340, 259);
			this.ChangePasswordLabel.Name = "ChangePasswordLabel";
			this.ChangePasswordLabel.Size = new System.Drawing.Size(112, 17);
			this.ChangePasswordLabel.TabIndex = 11;
			this.ChangePasswordLabel.Text = "Change Password";
			this.ChangePasswordLabel.Click += new System.EventHandler(this.ChangePasswordLabel_Click);
			// 
			// LoginErrorLabel
			// 
			this.LoginErrorLabel.AutoSize = true;
			this.LoginErrorLabel.BackColor = System.Drawing.Color.White;
			this.LoginErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.LoginErrorLabel.Location = new System.Drawing.Point(495, 166);
			this.LoginErrorLabel.Name = "LoginErrorLabel";
			this.LoginErrorLabel.Size = new System.Drawing.Size(0, 17);
			this.LoginErrorLabel.TabIndex = 12;
			this.LoginErrorLabel.Visible = false;
			// 
			// ProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 647);
			this.Controls.Add(this.LoginErrorLabel);
			this.Controls.Add(this.ChangePasswordLabel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.ChangePasswordBox);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.label1);
			this.Name = "ProfileForm";
			this.Text = "ProfileForm";
			this.ChangePasswordBox.ResumeLayout(false);
			this.ChangePasswordBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
		private GroupBox ChangePasswordBox;
		private Label label7;
		private Label ChangePasswordLabel;
		private Label LoginErrorLabel;
	}
}