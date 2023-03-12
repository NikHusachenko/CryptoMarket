using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
	
		public ProfileForm()
		{
			InitializeComponent();
			ChangePasswordBox.Visible= false;

		}

		private void SaveLabel_Click(object sender, EventArgs e)
		{
			bool isLoginCorrect = false;

			List<string> LoginList = new List<string>();// Here we get all Logins
			List<string> EmailList = new List<string>();// Here we get all Emails
			List<string> PasswordList = new List<string>();// Here we get all Passwords
			LoginList.Add("1");
			EmailList.Add("1");
			PasswordList.Add("1");
			if (string.IsNullOrEmpty(LoginTextBox.Text)) 
			{
				LoginErrorLabel.Visible = true;
				LoginErrorLabel.Text = "<- Login Cannot be empty";
				MessageBox.Show("Login cannot be empty");
			}
			else if (LoginList.Contains(LoginTextBox.Text))
			{
				LoginErrorLabel.Visible = true;
				LoginErrorLabel.Text = "<- Such Login is already used";
			}
			
			
			
		}

		private void CancelLabel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChangePasswordLabel_Click(object sender, EventArgs e)
		{
			ChangePasswordBox.Visible = true;
		}

		private void LoginTextBox_TextChanged(object sender, EventArgs e)
		{
			LoginErrorLabel.Visible = false;
		}
	}
}
