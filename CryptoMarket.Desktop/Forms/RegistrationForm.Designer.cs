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
			this.LoginErrorLabel = new System.Windows.Forms.Label();
			this.EmailErrorLabel = new System.Windows.Forms.Label();
			this.PasswordErrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(360, 99);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(74, 17);
			this.LoginLabel.TabIndex = 0;
			this.LoginLabel.Text = "Enter Login";
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(300, 121);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(200, 25);
			this.LoginTextBox.TabIndex = 1;
			this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(300, 178);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(200, 25);
			this.EmailTextBox.TabIndex = 3;
			this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(350, 215);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(98, 17);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "Enter Password";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(300, 235);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(200, 25);
			this.PasswordTextBox.TabIndex = 5;
			this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(361, 158);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(73, 17);
			this.EmailLabel.TabIndex = 4;
			this.EmailLabel.Text = "Enter Email";
			// 
			// SaveRegistration
			// 
			this.SaveRegistration.Location = new System.Drawing.Point(336, 317);
			this.SaveRegistration.Name = "SaveRegistration";
			this.SaveRegistration.Size = new System.Drawing.Size(133, 34);
			this.SaveRegistration.TabIndex = 6;
			this.SaveRegistration.Text = "Save";
			this.SaveRegistration.UseVisualStyleBackColor = true;
			this.SaveRegistration.Click += new System.EventHandler(this.SaveRegistration_Click);
			// 
			// LoginErrorLabel
			// 
			this.LoginErrorLabel.AutoSize = true;
			this.LoginErrorLabel.BackColor = System.Drawing.Color.White;
			this.LoginErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.LoginErrorLabel.Location = new System.Drawing.Point(506, 124);
			this.LoginErrorLabel.Name = "LoginErrorLabel";
			this.LoginErrorLabel.Size = new System.Drawing.Size(43, 17);
			this.LoginErrorLabel.TabIndex = 7;
			this.LoginErrorLabel.Text = "label4";
			this.LoginErrorLabel.Visible = false;
			// 
			// EmailErrorLabel
			// 
			this.EmailErrorLabel.AutoSize = true;
			this.EmailErrorLabel.BackColor = System.Drawing.Color.White;
			this.EmailErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.EmailErrorLabel.Location = new System.Drawing.Point(506, 181);
			this.EmailErrorLabel.Name = "EmailErrorLabel";
			this.EmailErrorLabel.Size = new System.Drawing.Size(43, 17);
			this.EmailErrorLabel.TabIndex = 8;
			this.EmailErrorLabel.Text = "label5";
			this.EmailErrorLabel.Visible = false;
			// 
			// PasswordErrorLabel
			// 
			this.PasswordErrorLabel.AutoSize = true;
			this.PasswordErrorLabel.BackColor = System.Drawing.Color.White;
			this.PasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.PasswordErrorLabel.Location = new System.Drawing.Point(506, 238);
			this.PasswordErrorLabel.Name = "PasswordErrorLabel";
			this.PasswordErrorLabel.Size = new System.Drawing.Size(43, 17);
			this.PasswordErrorLabel.TabIndex = 9;
			this.PasswordErrorLabel.Text = "label6";
			this.PasswordErrorLabel.Visible = false;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 480);
			this.Controls.Add(this.PasswordErrorLabel);
			this.Controls.Add(this.EmailErrorLabel);
			this.Controls.Add(this.LoginErrorLabel);
			this.Controls.Add(this.SaveRegistration);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.LoginLabel);
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
		private Label LoginErrorLabel;
		private Label EmailErrorLabel;
		private Label PasswordErrorLabel;
	}
}