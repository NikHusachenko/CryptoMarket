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
			this.PasswordTextBox.Location = new System.Drawing.Point(692, 389);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(200, 25);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// SignInLabel
			// 
			this.SignInLabel.AutoSize = true;
			this.SignInLabel.Location = new System.Drawing.Point(764, 426);
			this.SignInLabel.Name = "SignInLabel";
			this.SignInLabel.Size = new System.Drawing.Size(47, 17);
			this.SignInLabel.TabIndex = 2;
			this.SignInLabel.Text = "Sign in";
			this.SignInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
			// 
			// SignUpLabel
			// 
			this.SignUpLabel.AutoSize = true;
			this.SignUpLabel.Location = new System.Drawing.Point(52, 812);
			this.SignUpLabel.Name = "SignUpLabel";
			this.SignUpLabel.Size = new System.Drawing.Size(54, 17);
			this.SignUpLabel.TabIndex = 3;
			this.SignUpLabel.Text = "Sign Up";
			this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 860);
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
	}
}