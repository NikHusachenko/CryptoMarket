namespace CryptoMarket.Desktop.Forms
{
	partial class WalletsForm
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
			this.WalletInfoPanel = new System.Windows.Forms.Panel();
			this.WalletsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.WalletsFlowLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// WalletInfoPanel
			// 
			this.WalletInfoPanel.Location = new System.Drawing.Point(0, 352);
			this.WalletInfoPanel.Name = "WalletInfoPanel";
			this.WalletInfoPanel.Size = new System.Drawing.Size(1585, 512);
			this.WalletInfoPanel.TabIndex = 0;
			this.WalletInfoPanel.Visible = false;
			// 
			// WalletsFlowLayoutPanel
			// 
			this.WalletsFlowLayoutPanel.Controls.Add(this.button3);
			this.WalletsFlowLayoutPanel.Location = new System.Drawing.Point(1, 3);
			this.WalletsFlowLayoutPanel.Name = "WalletsFlowLayoutPanel";
			this.WalletsFlowLayoutPanel.Size = new System.Drawing.Size(1581, 349);
			this.WalletsFlowLayoutPanel.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Segoe UI", 47.76237F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(3, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(388, 329);
			this.button3.TabIndex = 9;
			this.button3.Text = "+";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// WalletsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1584, 860);
			this.Controls.Add(this.WalletsFlowLayoutPanel);
			this.Controls.Add(this.WalletInfoPanel);
			this.Name = "WalletsForm";
			this.Text = "WalletsForm";
			this.WalletsFlowLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel WalletInfoPanel;
		private FlowLayoutPanel WalletsFlowLayoutPanel;
		private Button button3;
	}
}