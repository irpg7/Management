namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navMain = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBill = new DevExpress.XtraNavBar.NavBarItem();
            this.navCustomers = new DevExpress.XtraNavBar.NavBarItem();
            this.navProducts = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navMain;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navMain});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBill,
            this.navCustomers,
            this.navProducts});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 230;
            this.navBarControl1.Size = new System.Drawing.Size(230, 514);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navMain
            // 
            this.navMain.Caption = "Menu";
            this.navMain.Expanded = true;
            this.navMain.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBill),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCustomers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navProducts)});
            this.navMain.Name = "navMain";
            // 
            // navBill
            // 
            this.navBill.Caption = "Fatura";
            this.navBill.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBill.ImageOptions.SmallImage")));
            this.navBill.Name = "navBill";
            this.navBill.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBill_LinkClicked);
            // 
            // navCustomers
            // 
            this.navCustomers.Caption = "Müşteriler";
            this.navCustomers.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navCustomers.ImageOptions.SmallImage")));
            this.navCustomers.Name = "navCustomers";
            this.navCustomers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCustomers_LinkClicked);
            // 
            // navProducts
            // 
            this.navProducts.Caption = "Ürünler";
            this.navProducts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navProducts.ImageOptions.SmallImage")));
            this.navProducts.Name = "navProducts";
            this.navProducts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navProducts_LinkClicked);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 514);
            this.Controls.Add(this.navBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navMain;
        private DevExpress.XtraNavBar.NavBarItem navBill;
        private DevExpress.XtraNavBar.NavBarItem navCustomers;
        private DevExpress.XtraNavBar.NavBarItem navProducts;
    }
}