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
			this.SignInLabel = new System.Windows.Forms.Label();
			this.SignUpLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(692, 347);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(200, 25);
			this.LoginTextBox.TabIndex = 0;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(692, 395);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(200, 25);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// SignInLabel
			// 
			this.SignInLabel.AutoSize = true;
			this.SignInLabel.Location = new System.Drawing.Point(764, 432);
			this.SignInLabel.Name = "SignInLabel";
			this.SignInLabel.Size = new System.Drawing.Size(47, 17);
			this.SignInLabel.TabIndex = 2;
			this.SignInLabel.Text = "Sign in";
			this.SignInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
			// 
			// SignUpLabel
			// 
			this.SignUpLabel.AutoSize = true;
			this.SignUpLabel.Font = new System.Drawing.Font("Segoe UI", 25.66337F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignUpLabel.Location = new System.Drawing.Point(52, 777);
			this.SignUpLabel.Name = "SignUpLabel";
			this.SignUpLabel.Size = new System.Drawing.Size(145, 48);
			this.SignUpLabel.TabIndex = 3;
			this.SignUpLabel.Text = "Sign Up";
			this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(748, 327);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(748, 375);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Enter Password";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 860);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SignUpLabel);
			this.Controls.Add(this.SignInLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox LoginTextBox;
		private TextBox PasswordTextBox;
		private Label SignInLabel;
		private Label SignUpLabel;
		private Label label1;
		private Label label2;
	}
}