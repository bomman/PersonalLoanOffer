namespace PersonalLoanOffer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.offerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOffersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientProductsToolStripMenuItem,
            this.offerFormToolStripMenuItem,
            this.listOffersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // offerFormToolStripMenuItem
            // 
            this.offerFormToolStripMenuItem.Name = "offerFormToolStripMenuItem";
            this.offerFormToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.offerFormToolStripMenuItem.Text = "Offer Form";
            this.offerFormToolStripMenuItem.Click += new System.EventHandler(this.offerFormToolStripMenuItem_Click);
            // 
            // clientProductsToolStripMenuItem
            // 
            this.clientProductsToolStripMenuItem.Name = "clientProductsToolStripMenuItem";
            this.clientProductsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.clientProductsToolStripMenuItem.Text = "Client Products";
            this.clientProductsToolStripMenuItem.Click += new System.EventHandler(this.clientProductsToolStripMenuItem_Click);
            // 
            // listOffersToolStripMenuItem
            // 
            this.listOffersToolStripMenuItem.Name = "listOffersToolStripMenuItem";
            this.listOffersToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.listOffersToolStripMenuItem.Text = "List Offers";
            this.listOffersToolStripMenuItem.Click += new System.EventHandler(this.listOffersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem offerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOffersToolStripMenuItem;
    }
}