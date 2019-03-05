namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmMain
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            this.tbarGroup = new DevExpress.XtraBars.Navigation.TileBar();
            this.tbGroupCommon = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnNewCustomer = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnRefresh = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnExport = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbGroupAdmin = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnImport = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnNewEmployee = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnNewTeam = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnNewUser = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.vwCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAppointment = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarGroup
            // 
            this.tbarGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbarGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbarGroup.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tbarGroup.Groups.Add(this.tbGroupCommon);
            this.tbarGroup.Groups.Add(this.tbGroupAdmin);
            this.tbarGroup.ItemSize = 40;
            this.tbarGroup.Location = new System.Drawing.Point(0, 0);
            this.tbarGroup.MaxId = 9;
            this.tbarGroup.Name = "tbarGroup";
            this.tbarGroup.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.tbarGroup.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tbarGroup.Size = new System.Drawing.Size(954, 84);
            this.tbarGroup.TabIndex = 0;
            this.tbarGroup.Text = "tileBar1";
            this.tbarGroup.WideTileWidth = 100;
            // 
            // tbGroupCommon
            // 
            this.tbGroupCommon.Items.Add(this.tbtnNewCustomer);
            this.tbGroupCommon.Items.Add(this.tbtnRefresh);
            this.tbGroupCommon.Items.Add(this.tbtnExport);
            this.tbGroupCommon.Name = "tbGroupCommon";
            // 
            // tbtnNewCustomer
            // 
            this.tbtnNewCustomer.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnNewCustomer.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnNewCustomer.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnNewCustomer.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnNewCustomer.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnNewCustomer.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnNewCustomer.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnNewCustomer.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnNewCustomer.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Yeni Müşteri";
            this.tbtnNewCustomer.Elements.Add(tileItemElement1);
            this.tbtnNewCustomer.Id = 0;
            this.tbtnNewCustomer.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnNewCustomer.Name = "tbtnNewCustomer";
            this.tbtnNewCustomer.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnNewCustomer_ItemClick);
            // 
            // tbtnRefresh
            // 
            this.tbtnRefresh.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnRefresh.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnRefresh.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnRefresh.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnRefresh.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnRefresh.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnRefresh.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnRefresh.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnRefresh.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Yenile";
            this.tbtnRefresh.Elements.Add(tileItemElement2);
            this.tbtnRefresh.Id = 1;
            this.tbtnRefresh.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnRefresh.Name = "tbtnRefresh";
            this.tbtnRefresh.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnRefresh_ItemClick);
            // 
            // tbtnExport
            // 
            this.tbtnExport.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnExport.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnExport.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnExport.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnExport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnExport.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnExport.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnExport.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnExport.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "Excel\'e Aktar";
            this.tbtnExport.Elements.Add(tileItemElement3);
            this.tbtnExport.Id = 2;
            this.tbtnExport.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnExport.Name = "tbtnExport";
            this.tbtnExport.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnExport_ItemClick);
            // 
            // tbGroupAdmin
            // 
            this.tbGroupAdmin.Items.Add(this.tbtnImport);
            this.tbGroupAdmin.Items.Add(this.tbtnNewEmployee);
            this.tbGroupAdmin.Items.Add(this.tbtnNewTeam);
            this.tbGroupAdmin.Items.Add(this.tbtnNewUser);
            this.tbGroupAdmin.Name = "tbGroupAdmin";
            this.tbGroupAdmin.Text = "Yönetim";
            // 
            // tbtnImport
            // 
            this.tbtnImport.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnImport.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnImport.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnImport.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnImport.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnImport.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnImport.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnImport.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnImport.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Excel\'den Aktar";
            this.tbtnImport.Elements.Add(tileItemElement4);
            this.tbtnImport.Id = 5;
            this.tbtnImport.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnImport.Name = "tbtnImport";
            this.tbtnImport.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnImport_ItemClick);
            // 
            // tbtnNewEmployee
            // 
            this.tbtnNewEmployee.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnNewEmployee.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnNewEmployee.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnNewEmployee.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnNewEmployee.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnNewEmployee.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnNewEmployee.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnNewEmployee.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnNewEmployee.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "Temsilci Ekle";
            this.tbtnNewEmployee.Elements.Add(tileItemElement5);
            this.tbtnNewEmployee.Id = 6;
            this.tbtnNewEmployee.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnNewEmployee.Name = "tbtnNewEmployee";
            this.tbtnNewEmployee.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnNewEmployee_ItemClick);
            // 
            // tbtnNewTeam
            // 
            this.tbtnNewTeam.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnNewTeam.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnNewTeam.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnNewTeam.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnNewTeam.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnNewTeam.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnNewTeam.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnNewTeam.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnNewTeam.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "Ekip Oluştur";
            this.tbtnNewTeam.Elements.Add(tileItemElement6);
            this.tbtnNewTeam.Id = 7;
            this.tbtnNewTeam.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnNewTeam.Name = "tbtnNewTeam";
            this.tbtnNewTeam.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnNewTeam_ItemClick);
            // 
            // tbtnNewUser
            // 
            this.tbtnNewUser.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnNewUser.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnNewUser.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnNewUser.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnNewUser.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnNewUser.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnNewUser.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnNewUser.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnNewUser.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            tileItemElement7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement7.Text = "Kullanıcı Oluştur";
            this.tbtnNewUser.Elements.Add(tileItemElement7);
            this.tbtnNewUser.Id = 8;
            this.tbtnNewUser.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnNewUser.Name = "tbtnNewUser";
            this.tbtnNewUser.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnNewUser_ItemClick);
            // 
            // grdCustomers
            // 
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomers.Location = new System.Drawing.Point(0, 84);
            this.grdCustomers.MainView = this.vwCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(954, 388);
            this.grdCustomers.TabIndex = 1;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwCustomers});
            // 
            // vwCustomers
            // 
            this.vwCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colTaxNo,
            this.colTaxDepartment,
            this.colAddress,
            this.colDebated,
            this.colActive,
            this.colAppointment});
            this.vwCustomers.GridControl = this.grdCustomers;
            this.vwCustomers.Name = "vwCustomers";
            this.vwCustomers.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.vwCustomers.OptionsView.ShowAutoFilterRow = true;
            this.vwCustomers.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vwCustomers_RowClick);
            // 
            // colCode
            // 
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "CustomerCode";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.OptionsColumn.AllowFocus = false;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Müşteri Adı";
            this.colName.FieldName = "CustomerName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colTaxNo
            // 
            this.colTaxNo.Caption = "Vergi/Tc No.";
            this.colTaxNo.FieldName = "CustomerTaxNo";
            this.colTaxNo.Name = "colTaxNo";
            this.colTaxNo.OptionsColumn.AllowEdit = false;
            this.colTaxNo.OptionsColumn.AllowFocus = false;
            this.colTaxNo.Visible = true;
            this.colTaxNo.VisibleIndex = 2;
            // 
            // colTaxDepartment
            // 
            this.colTaxDepartment.Caption = "Vergi Dairesi";
            this.colTaxDepartment.FieldName = "CustomerTaxDepartment";
            this.colTaxDepartment.Name = "colTaxDepartment";
            this.colTaxDepartment.OptionsColumn.AllowEdit = false;
            this.colTaxDepartment.OptionsColumn.AllowFocus = false;
            this.colTaxDepartment.Visible = true;
            this.colTaxDepartment.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Adres";
            this.colAddress.FieldName = "CustomerAddress";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // colDebated
            // 
            this.colDebated.Caption = "Görüşüldü";
            this.colDebated.FieldName = "CustomerDebated";
            this.colDebated.Name = "colDebated";
            this.colDebated.OptionsColumn.AllowEdit = false;
            this.colDebated.OptionsColumn.AllowFocus = false;
            this.colDebated.Visible = true;
            this.colDebated.VisibleIndex = 5;
            // 
            // colActive
            // 
            this.colActive.Caption = "Aktif";
            this.colActive.FieldName = "CustomerActive";
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.AllowEdit = false;
            this.colActive.OptionsColumn.AllowFocus = false;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 6;
            // 
            // colAppointment
            // 
            this.colAppointment.Caption = "Randevu";
            this.colAppointment.FieldName = "CustomerGotAppointment";
            this.colAppointment.Name = "colAppointment";
            this.colAppointment.OptionsColumn.AllowEdit = false;
            this.colAppointment.OptionsColumn.AllowFocus = false;
            this.colAppointment.Visible = true;
            this.colAppointment.VisibleIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 472);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.tbarGroup);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tbarGroup;
        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView vwCustomers;
        private DevExpress.XtraBars.Navigation.TileBarGroup tbGroupCommon;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnNewCustomer;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnRefresh;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnExport;
        private DevExpress.XtraBars.Navigation.TileBarGroup tbGroupAdmin;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnImport;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnNewEmployee;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnNewTeam;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnNewUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDebated;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colAppointment;
    }
}