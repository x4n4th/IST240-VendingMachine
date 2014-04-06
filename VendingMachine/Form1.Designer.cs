namespace VendingMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDollar = new System.Windows.Forms.Button();
            this.btnPenny = new System.Windows.Forms.Button();
            this.btnDime = new System.Windows.Forms.Button();
            this.btnNickel = new System.Windows.Forms.Button();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinksToolStripMenuItem,
            this.snacksToolStripMenuItem,
            this.candyToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.drinksToolStripMenuItem.Text = "Drinks";
            this.drinksToolStripMenuItem.Click += new System.EventHandler(this.drinksToolStripMenuItem_Click);
            // 
            // snacksToolStripMenuItem
            // 
            this.snacksToolStripMenuItem.Name = "snacksToolStripMenuItem";
            this.snacksToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.snacksToolStripMenuItem.Text = "Snacks";
            this.snacksToolStripMenuItem.Click += new System.EventHandler(this.snacksToolStripMenuItem_Click);
            // 
            // candyToolStripMenuItem
            // 
            this.candyToolStripMenuItem.Name = "candyToolStripMenuItem";
            this.candyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.candyToolStripMenuItem.Text = "Candy";
            this.candyToolStripMenuItem.Click += new System.EventHandler(this.candyToolStripMenuItem_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(628, 38);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(206, 20);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "Please Add Money For Selection ";
            // 
            // btnDollar
            // 
            this.btnDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDollar.Location = new System.Drawing.Point(628, 304);
            this.btnDollar.Name = "btnDollar";
            this.btnDollar.Size = new System.Drawing.Size(206, 100);
            this.btnDollar.TabIndex = 2;
            this.btnDollar.UseVisualStyleBackColor = true;
            this.btnDollar.Click += new System.EventHandler(this.onMoneyClick);
            // 
            // btnPenny
            // 
            this.btnPenny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPenny.Location = new System.Drawing.Point(628, 92);
            this.btnPenny.Name = "btnPenny";
            this.btnPenny.Size = new System.Drawing.Size(100, 100);
            this.btnPenny.TabIndex = 3;
            this.btnPenny.UseVisualStyleBackColor = true;
            this.btnPenny.Click += new System.EventHandler(this.onMoneyClick);
            // 
            // btnDime
            // 
            this.btnDime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDime.Location = new System.Drawing.Point(628, 198);
            this.btnDime.Name = "btnDime";
            this.btnDime.Size = new System.Drawing.Size(100, 100);
            this.btnDime.TabIndex = 4;
            this.btnDime.UseVisualStyleBackColor = true;
            this.btnDime.Click += new System.EventHandler(this.onMoneyClick);
            // 
            // btnNickel
            // 
            this.btnNickel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNickel.Location = new System.Drawing.Point(734, 92);
            this.btnNickel.Name = "btnNickel";
            this.btnNickel.Size = new System.Drawing.Size(100, 100);
            this.btnNickel.TabIndex = 5;
            this.btnNickel.UseVisualStyleBackColor = true;
            this.btnNickel.Click += new System.EventHandler(this.onMoneyClick);
            // 
            // btnQuarter
            // 
            this.btnQuarter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuarter.Location = new System.Drawing.Point(734, 198);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(100, 100);
            this.btnQuarter.TabIndex = 6;
            this.btnQuarter.UseVisualStyleBackColor = true;
            this.btnQuarter.Click += new System.EventHandler(this.onMoneyClick);
            // 
            // txtMoney
            // 
            this.txtMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoney.Location = new System.Drawing.Point(628, 64);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(206, 20);
            this.txtMoney.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 595);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnQuarter);
            this.Controls.Add(this.btnNickel);
            this.Controls.Add(this.btnDime);
            this.Controls.Add(this.btnPenny);
            this.Controls.Add(this.btnDollar);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vending Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnDollar;
        private System.Windows.Forms.Button btnPenny;
        private System.Windows.Forms.Button btnDime;
        private System.Windows.Forms.Button btnNickel;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMoney;
    }
}

