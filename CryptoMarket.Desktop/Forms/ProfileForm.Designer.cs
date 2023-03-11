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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.CancelBtn = new System.Windows.Forms.Label();
			this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
			this.ChangePasswordBox = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SaveProfileBtn = new System.Windows.Forms.Button();
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(292, 163);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 25);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(292, 222);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 25);
			this.textBox2.TabIndex = 3;
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
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(59, 124);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 25);
			this.textBox3.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(104, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "New Password";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(59, 56);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 25);
			this.textBox4.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(104, 36);
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
			this.label6.Location = new System.Drawing.Point(681, 676);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Save";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.AutoSize = true;
			this.CancelBtn.Location = new System.Drawing.Point(39, 676);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(46, 17);
			this.CancelBtn.TabIndex = 9;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// sqlCommand1
			// 
			this.sqlCommand1.CommandTimeout = 30;
			this.sqlCommand1.EnableOptimizedParameterBinding = false;
			// 
			// ChangePasswordBox
			// 
			this.ChangePasswordBox.Controls.Add(this.textBox4);
			this.ChangePasswordBox.Controls.Add(this.label4);
			this.ChangePasswordBox.Controls.Add(this.label3);
			this.ChangePasswordBox.Controls.Add(this.textBox3);
			this.ChangePasswordBox.Location = new System.Drawing.Point(227, 349);
			this.ChangePasswordBox.Name = "ChangePasswordBox";
			this.ChangePasswordBox.Size = new System.Drawing.Size(344, 206);
			this.ChangePasswordBox.TabIndex = 10;
			this.ChangePasswordBox.TabStop = false;
			this.ChangePasswordBox.Text = "ChangePassword";
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
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(331, 266);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 17);
			this.label8.TabIndex = 11;
			this.label8.Text = "Change Password";
			// 
			// SaveProfileBtn
			// 
			this.SaveProfileBtn.Location = new System.Drawing.Point(618, 516);
			this.SaveProfileBtn.Name = "SaveProfileBtn";
			this.SaveProfileBtn.Size = new System.Drawing.Size(135, 39);
			this.SaveProfileBtn.TabIndex = 12;
			this.SaveProfileBtn.Text = "Save Changes";
			this.SaveProfileBtn.UseVisualStyleBackColor = true;
			// 
			// ProfileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 721);
			this.Controls.Add(this.SaveProfileBtn);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.ChangePasswordBox);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
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
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label2;
		private TextBox textBox3;
		private Label label3;
		private TextBox textBox4;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label CancelBtn;
		private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
		private GroupBox ChangePasswordBox;
		private Label label7;
		private Label label8;
		private Button SaveProfileBtn;
	}
}