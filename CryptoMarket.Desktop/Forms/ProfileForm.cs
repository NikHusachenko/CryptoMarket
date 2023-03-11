using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMarket.Desktop.Forms
{
	public partial class ProfileForm : Form
	{
		public ProfileForm()
		{
			InitializeComponent();
		}

		private void label6_Click(object sender, EventArgs e)
		{

			
			this.Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
