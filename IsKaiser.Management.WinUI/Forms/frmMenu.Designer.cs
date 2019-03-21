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
            this.navEmployee = new DevExpress.XtraNavBar.NavBarGroup();
            this.navlinkEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.navlinkTeam = new DevExpress.XtraNavBar.NavBarItem();
            this.navlinkUser = new DevExpress.XtraNavBar.NavBarItem();
            this.navParameters = new DevExpress.XtraNavBar.NavBarGroup();
            this.navlinkCompanyInfo = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navMain;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navMain,
            this.navEmployee,
            this.navParameters});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBill,
            this.navCustomers,
            this.navProducts,
            this.navlinkEmployee,
            this.navlinkTeam,
            this.navlinkUser,
            this.navlinkCompanyInfo});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 250;
            this.navBarControl1.Size = new System.Drawing.Size(250, 514);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navMain
            // 
            this.navMain.Caption = "Müşteri";
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
            this.navCustomers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navCustomers.ImageOptions.LargeImage")));
            this.navCustomers.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navCustomers.ImageOptions.SmallImage")));
            this.navCustomers.Name = "navCustomers";
            this.navCustomers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCustomers_LinkClicked);
            // 
            // navProducts
            // 
            this.navProducts.Caption = "Ürünler";
            this.navProducts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navProducts.ImageOptions.LargeImage")));
            this.navProducts.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navProducts.ImageOptions.SmallImage")));
            this.navProducts.Name = "navProducts";
            this.navProducts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navProducts_LinkClicked);
            // 
            // navEmployee
            // 
            this.navEmployee.Caption = "Personel";
            this.navEmployee.Expanded = true;
            this.navEmployee.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navlinkEmployee),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navlinkTeam),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navlinkUser)});
            this.navEmployee.Name = "navEmployee";
            // 
            // navlinkEmployee
            // 
            this.navlinkEmployee.Caption = "Temsilci";
            this.navlinkEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navlinkEmployee.ImageOptions.LargeImage")));
            this.navlinkEmployee.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navlinkEmployee.ImageOptions.SmallImage")));
            this.navlinkEmployee.Name = "navlinkEmployee";
            this.navlinkEmployee.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavlinkEmployee_LinkClicked);
            // 
            // navlinkTeam
            // 
            this.navlinkTeam.Caption = "Ekip";
            this.navlinkTeam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navlinkTeam.ImageOptions.LargeImage")));
            this.navlinkTeam.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navlinkTeam.ImageOptions.SmallImage")));
            this.navlinkTeam.Name = "navlinkTeam";
            this.navlinkTeam.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavlinkTeam_LinkClicked);
            // 
            // navlinkUser
            // 
            this.navlinkUser.Caption = "Kullanıcı";
            this.navlinkUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navlinkUser.ImageOptions.LargeImage")));
            this.navlinkUser.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navlinkUser.ImageOptions.SmallImage")));
            this.navlinkUser.Name = "navlinkUser";
            this.navlinkUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavlinkUser_LinkClicked);
            // 
            // navParameters
            // 
            this.navParameters.Caption = "Firma";
            this.navParameters.Expanded = true;
            this.navParameters.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navlinkCompanyInfo)});
            this.navParameters.Name = "navParameters";
            // 
            // navlinkCompanyInfo
            // 
            this.navlinkCompanyInfo.Caption = "Firma Bilgileri";
            this.navlinkCompanyInfo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navlinkCompanyInfo.ImageOptions.LargeImage")));
            this.navlinkCompanyInfo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navlinkCompanyInfo.ImageOptions.SmallImage")));
            this.navlinkCompanyInfo.Name = "navlinkCompanyInfo";
            this.navlinkCompanyInfo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavlinkCompanyInfo_LinkClicked);
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
            this.Text = "Menü";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navMain;
        private DevExpress.XtraNavBar.NavBarItem navBill;
        private DevExpress.XtraNavBar.NavBarItem navCustomers;
        private DevExpress.XtraNavBar.NavBarItem navProducts;
        private DevExpress.XtraNavBar.NavBarGroup navEmployee;
        private DevExpress.XtraNavBar.NavBarItem navlinkEmployee;
        private DevExpress.XtraNavBar.NavBarItem navlinkTeam;
        private DevExpress.XtraNavBar.NavBarItem navlinkUser;
        private DevExpress.XtraNavBar.NavBarGroup navParameters;
        private DevExpress.XtraNavBar.NavBarItem navlinkCompanyInfo;
    }
}