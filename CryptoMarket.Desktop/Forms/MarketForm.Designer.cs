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
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            marketToolStripMenuItem1 = new ToolStripMenuItem();
            coinsToolStripMenuItem = new ToolStripMenuItem();
            exchangesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            myProfileToolStripMenuItem = new ToolStripMenuItem();
            walletsToolStripMenuItem = new ToolStripMenuItem();
            marketToolStripMenuItem = new ToolStripComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            currenciesFlowLayoutPanel = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(17, 17);
            menuStrip1.Items.AddRange(new ToolStripItem[] { marketToolStripMenuItem1, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1356, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // marketToolStripMenuItem1
            // 
            marketToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { coinsToolStripMenuItem, exchangesToolStripMenuItem });
            marketToolStripMenuItem1.Name = "marketToolStripMenuItem1";
            marketToolStripMenuItem1.Size = new Size(56, 20);
            marketToolStripMenuItem1.Text = "Market";
            marketToolStripMenuItem1.TextImageRelation = TextImageRelation.TextAboveImage;
            // 
            // coinsToolStripMenuItem
            // 
            coinsToolStripMenuItem.Name = "coinsToolStripMenuItem";
            coinsToolStripMenuItem.Size = new Size(130, 22);
            coinsToolStripMenuItem.Text = "Coins";
            coinsToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exchangesToolStripMenuItem
            // 
            exchangesToolStripMenuItem.Name = "exchangesToolStripMenuItem";
            exchangesToolStripMenuItem.Size = new Size(130, 22);
            exchangesToolStripMenuItem.Text = "Exchanges";
            exchangesToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myProfileToolStripMenuItem, walletsToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 20);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // myProfileToolStripMenuItem
            // 
            myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            myProfileToolStripMenuItem.Size = new Size(128, 22);
            myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // walletsToolStripMenuItem
            // 
            walletsToolStripMenuItem.Name = "walletsToolStripMenuItem";
            walletsToolStripMenuItem.Size = new Size(128, 22);
            walletsToolStripMenuItem.Text = "Wallets";
            // 
            // marketToolStripMenuItem
            // 
            marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            marketToolStripMenuItem.Size = new Size(75, 25);
            marketToolStripMenuItem.Text = "Market";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 60);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 60);
            label6.Name = "label6";
            label6.Size = new Size(43, 17);
            label6.TabIndex = 2;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 31);
            label7.Name = "label7";
            label7.Size = new Size(43, 17);
            label7.TabIndex = 1;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 31);
            label8.Name = "label8";
            label8.Size = new Size(43, 17);
            label8.TabIndex = 0;
            label8.Text = "label8";
            // 
            // currenciesFlowLayoutPanel
            // 
            currenciesFlowLayoutPanel.AutoScroll = true;
            currenciesFlowLayoutPanel.Location = new Point(0, 23);
            currenciesFlowLayoutPanel.Name = "currenciesFlowLayoutPanel";
            currenciesFlowLayoutPanel.Size = new Size(1350, 794);
            currenciesFlowLayoutPanel.TabIndex = 4;
            // 
            // MarketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 759);
            Controls.Add(currenciesFlowLayoutPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MarketForm";
            Text = "MarketForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}