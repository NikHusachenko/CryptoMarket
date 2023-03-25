using CryptoMarket.Database.Entities;
using CryptoMarket.EntityFramework.Repository;
using CryptoMarket.EntityFramework;
using CryptoMarket.Services.CoinGreckoServices;
using Microsoft.Identity.Client;
using CryptoMarket.Services.Response;
using CryptoMarket.Common;
using System.Runtime.CompilerServices;

namespace CryptoMarket.Desktop.Forms
{
	partial class MarketForm
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
		/// 
		
		public static async void AddToFlowLayot(FlowLayoutPanel flowLayoutPanel)
		{
			if (coins == null)
			{
				await InitCoins();
			}

			int start = currentPage * MarketFormConstants.COINS_ON_PAGE;
			int end = start + MarketFormConstants.COINS_ON_PAGE;

			flowLayoutPanel.Controls.Clear();
			for (int i = start; i < end && i<coins.Value.Count; i++)
			{
				string[] labelText = { "CoinId:", "Name:", "Symbol:" };
				string[] dataText = { coins.Value[i].CoinId, coins.Value[i].Name, coins.Value[i].Symbol};
				List<Label> labels = new List<Label>();
				for (int y = 0; y < 3; y++)
				{
					labels.Add(CreateLabel(labelText[y], new Point(7, 32 * (y + 1))));
					labels.Add(CreateLabel(dataText[y], new Point(68, 32 * (y + 1))));
				}

				GroupBox groupBox = new GroupBox()
				{

					Location = new Point(3, 3),
					Size = new System.Drawing.Size(320, 200),
					Margin = new Padding(5, 5, 5, 5),
					Name = "groupBox",
					Text = coins.Value[i].Name,
				};
				groupBox.Controls.AddRange(labels.ToArray());
				groupBox.Click += groupBox_Click;
				flowLayoutPanel.Controls.Add(groupBox);
			}
		}
		
		
		private static Label CreateLabel(string text, Point location)
		{
			return new Label()
			{
				AutoSize = true,
				Location = location,
				Size = new Size(43, 17),
				Text = text
			};
		}
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.marketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.coinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exchangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.walletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.currenciesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.NextPageBtn = new System.Windows.Forms.Button();
			this.PreviousPageBtn = new System.Windows.Forms.Button();
			this.PageNumberInfoLab = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketToolStripMenuItem1,
            this.profileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1356, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// marketToolStripMenuItem1
			// 
			this.marketToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coinsToolStripMenuItem,
            this.exchangesToolStripMenuItem});
			this.marketToolStripMenuItem1.Name = "marketToolStripMenuItem1";
			this.marketToolStripMenuItem1.Size = new System.Drawing.Size(61, 21);
			this.marketToolStripMenuItem1.Text = "Market";
			this.marketToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			// 
			// coinsToolStripMenuItem
			// 
			this.coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
			this.coinsToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.coinsToolStripMenuItem.Text = "Coins";
			this.coinsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// exchangesToolStripMenuItem
			// 
			this.exchangesToolStripMenuItem.Name = "exchangesToolStripMenuItem";
			this.exchangesToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.exchangesToolStripMenuItem.Text = "Exchanges";
			this.exchangesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// profileToolStripMenuItem
			// 
			this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.walletsToolStripMenuItem});
			this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
			this.profileToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
			this.profileToolStripMenuItem.Text = "Profile";
			// 
			// myProfileToolStripMenuItem
			// 
			this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
			this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.myProfileToolStripMenuItem.Text = "My Profile";
			// 
			// walletsToolStripMenuItem
			// 
			this.walletsToolStripMenuItem.Name = "walletsToolStripMenuItem";
			this.walletsToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.walletsToolStripMenuItem.Text = "Wallets";
			// 
			// marketToolStripMenuItem
			// 
			this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
			this.marketToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
			this.marketToolStripMenuItem.Text = "Market";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(93, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 17);
			this.label6.TabIndex = 2;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(93, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 17);
			this.label7.TabIndex = 1;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 31);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "label8";
			// 
			// currenciesFlowLayoutPanel
			// 
			this.currenciesFlowLayoutPanel.AutoScroll = true;
			this.currenciesFlowLayoutPanel.Location = new System.Drawing.Point(0, 26);
			this.currenciesFlowLayoutPanel.Name = "currenciesFlowLayoutPanel";
			this.currenciesFlowLayoutPanel.Size = new System.Drawing.Size(1350, 767);
			this.currenciesFlowLayoutPanel.TabIndex = 4;
			// 
			// NextPageBtn
			// 
			this.NextPageBtn.Location = new System.Drawing.Point(732, 803);
			this.NextPageBtn.Name = "NextPageBtn";
			this.NextPageBtn.Size = new System.Drawing.Size(98, 49);
			this.NextPageBtn.TabIndex = 5;
			this.NextPageBtn.Text = "Next Page";
			this.NextPageBtn.UseVisualStyleBackColor = true;
			this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
			// 
			// PreviousPageBtn
			// 
			this.PreviousPageBtn.Location = new System.Drawing.Point(526, 803);
			this.PreviousPageBtn.Name = "PreviousPageBtn";
			this.PreviousPageBtn.Size = new System.Drawing.Size(99, 49);
			this.PreviousPageBtn.TabIndex = 6;
			this.PreviousPageBtn.Text = "Previous Page";
			this.PreviousPageBtn.UseVisualStyleBackColor = true;
			this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
			// 
			// PageNumberInfoLab
			// 
			this.PageNumberInfoLab.Font = new System.Drawing.Font("Segoe UI Semibold", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.PageNumberInfoLab.Location = new System.Drawing.Point(631, 809);
			this.PageNumberInfoLab.Name = "PageNumberInfoLab";
			this.PageNumberInfoLab.Size = new System.Drawing.Size(95, 33);
			this.PageNumberInfoLab.TabIndex = 7;
			this.PageNumberInfoLab.Text = "1/74";
			this.PageNumberInfoLab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// MarketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1356, 860);
			this.Controls.Add(this.PageNumberInfoLab);
			this.Controls.Add(this.PreviousPageBtn);
			this.Controls.Add(this.NextPageBtn);
			this.Controls.Add(this.currenciesFlowLayoutPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MarketForm";
			this.Text = "MarketForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem marketToolStripMenuItem1;
		private ToolStripMenuItem coinsToolStripMenuItem;
		private ToolStripMenuItem exchangesToolStripMenuItem;
		private ToolStripMenuItem profileToolStripMenuItem;
		private ToolStripMenuItem myProfileToolStripMenuItem;
		private ToolStripMenuItem walletsToolStripMenuItem;
		private ToolStripComboBox marketToolStripMenuItem;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private FlowLayoutPanel currenciesFlowLayoutPanel;
		private Button NextPageBtn;
		private Button PreviousPageBtn;
		private Label PageNumberInfoLab;
	}
}