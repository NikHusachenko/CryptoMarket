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
            WalletInfoPanel = new Panel();
            WalletsFlowLayoutPanel = new FlowLayoutPanel();
            AddWalletBtn = new Button();
            WalletsFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // WalletInfoPanel
            // 
            WalletInfoPanel.Location = new Point(0, 311);
            WalletInfoPanel.Name = "WalletInfoPanel";
            WalletInfoPanel.Size = new Size(1585, 452);
            WalletInfoPanel.TabIndex = 0;
            WalletInfoPanel.Visible = false;
            // 
            // WalletsFlowLayoutPanel
            // 
            WalletsFlowLayoutPanel.Controls.Add(AddWalletBtn);
            WalletsFlowLayoutPanel.Location = new Point(1, 3);
            WalletsFlowLayoutPanel.Name = "WalletsFlowLayoutPanel";
            WalletsFlowLayoutPanel.Size = new Size(1581, 308);
            WalletsFlowLayoutPanel.TabIndex = 1;
            // 
            // AddWalletBtn
            // 
            AddWalletBtn.Font = new Font("Segoe UI", 47.76237F, FontStyle.Regular, GraphicsUnit.Point);
            AddWalletBtn.Location = new Point(3, 3);
            AddWalletBtn.Name = "AddWalletBtn";
            AddWalletBtn.Size = new Size(388, 290);
            AddWalletBtn.TabIndex = 9;
            AddWalletBtn.Text = "+";
            AddWalletBtn.UseVisualStyleBackColor = true;
            AddWalletBtn.Click += AddWalletBtn_Click;
            // 
            // WalletsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 759);
            Controls.Add(WalletsFlowLayoutPanel);
            Controls.Add(WalletInfoPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WalletsForm";
            Text = "WalletsForm";
            WalletsFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel WalletInfoPanel;
        private FlowLayoutPanel WalletsFlowLayoutPanel;
        private Button AddWalletBtn;
    }
}