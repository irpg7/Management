namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repocmbWithholding = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tabNewBill = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.txtWaybillNo = new DevExpress.XtraEditors.TextEdit();
            this.lblWaybillNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cmbInvoiceType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderNo = new DevExpress.XtraEditors.LabelControl();
            this.lblOrderDate = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderedBy = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderedBy = new DevExpress.XtraEditors.LabelControl();
            this.txtRequest = new DevExpress.XtraEditors.TextEdit();
            this.lblRequested = new DevExpress.XtraEditors.LabelControl();
            this.txtTaxRate = new DevExpress.XtraEditors.TextEdit();
            this.txtSerie = new DevExpress.XtraEditors.TextEdit();
            this.txtRefNo = new DevExpress.XtraEditors.TextEdit();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.cmbCustomers = new DevExpress.XtraEditors.LookUpEdit();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.cmbWithholding = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblWithholding = new DevExpress.XtraEditors.LabelControl();
            this.lblTaxRate = new DevExpress.XtraEditors.LabelControl();
            this.lblExpiry = new DevExpress.XtraEditors.LabelControl();
            this.lblRefNo = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomer = new DevExpress.XtraEditors.LabelControl();
            this.lblNo = new DevExpress.XtraEditors.LabelControl();
            this.lblSerie = new DevExpress.XtraEditors.LabelControl();
            this.barForNew = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnSave = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnPrint = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnDesign = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.grdBill = new DevExpress.XtraGrid.GridControl();
            this.vwBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupProduct = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpExpiry = new DevExpress.XtraEditors.TextEdit();
            this.tabBillList = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridBillList = new DevExpress.XtraGrid.GridControl();
            this.vwBillList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBillDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdcmbTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSerie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookupCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colExpiry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWithholding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalWithTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barForList = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup3 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnGoTo = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnPrintList = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tabPanel = new DevExpress.XtraBars.Navigation.TabPane();
            this.tbtnAttachments = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repocmbWithholding)).BeginInit();
            this.tabNewBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaybillNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWithholding.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpiry.Properties)).BeginInit();
            this.tabBillList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBillList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBillList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcmbTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Ürün"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductDescription", "Açıklama")});
            this.repositoryItemLookUpEdit1.DisplayMember = "ProductName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ProductId";
            // 
            // repocmbWithholding
            // 
            this.repocmbWithholding.AutoHeight = false;
            this.repocmbWithholding.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repocmbWithholding.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.repocmbWithholding.Name = "repocmbWithholding";
            // 
            // tabNewBill
            // 
            this.tabNewBill.Caption = "Yeni Fatura";
            this.tabNewBill.Controls.Add(this.dtpOrderDate);
            this.tabNewBill.Controls.Add(this.txtWaybillNo);
            this.tabNewBill.Controls.Add(this.lblWaybillNo);
            this.tabNewBill.Controls.Add(this.labelControl13);
            this.tabNewBill.Controls.Add(this.cmbInvoiceType);
            this.tabNewBill.Controls.Add(this.txtOrderNo);
            this.tabNewBill.Controls.Add(this.lblOrderNo);
            this.tabNewBill.Controls.Add(this.lblOrderDate);
            this.tabNewBill.Controls.Add(this.txtOrderedBy);
            this.tabNewBill.Controls.Add(this.lblOrderedBy);
            this.tabNewBill.Controls.Add(this.txtRequest);
            this.tabNewBill.Controls.Add(this.lblRequested);
            this.tabNewBill.Controls.Add(this.txtTaxRate);
            this.tabNewBill.Controls.Add(this.txtSerie);
            this.tabNewBill.Controls.Add(this.txtRefNo);
            this.tabNewBill.Controls.Add(this.txtNo);
            this.tabNewBill.Controls.Add(this.cmbCustomers);
            this.tabNewBill.Controls.Add(this.dtpDate);
            this.tabNewBill.Controls.Add(this.cmbWithholding);
            this.tabNewBill.Controls.Add(this.lblWithholding);
            this.tabNewBill.Controls.Add(this.lblTaxRate);
            this.tabNewBill.Controls.Add(this.lblExpiry);
            this.tabNewBill.Controls.Add(this.lblRefNo);
            this.tabNewBill.Controls.Add(this.lblDate);
            this.tabNewBill.Controls.Add(this.lblCustomer);
            this.tabNewBill.Controls.Add(this.lblNo);
            this.tabNewBill.Controls.Add(this.lblSerie);
            this.tabNewBill.Controls.Add(this.barForNew);
            this.tabNewBill.Controls.Add(this.grdBill);
            this.tabNewBill.Controls.Add(this.dtpExpiry);
            this.tabNewBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNewBill.ImageOptions.Image")));
            this.tabNewBill.Name = "tabNewBill";
            this.tabNewBill.Size = new System.Drawing.Size(992, 526);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.EditValue = null;
            this.dtpOrderDate.Location = new System.Drawing.Point(821, 145);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpOrderDate.Size = new System.Drawing.Size(156, 20);
            this.dtpOrderDate.TabIndex = 9;
            // 
            // txtWaybillNo
            // 
            this.txtWaybillNo.Location = new System.Drawing.Point(73, 171);
            this.txtWaybillNo.Name = "txtWaybillNo";
            this.txtWaybillNo.Size = new System.Drawing.Size(146, 20);
            this.txtWaybillNo.TabIndex = 10;
            // 
            // lblWaybillNo
            // 
            this.lblWaybillNo.Location = new System.Drawing.Point(12, 174);
            this.lblWaybillNo.Name = "lblWaybillNo";
            this.lblWaybillNo.Size = new System.Drawing.Size(55, 13);
            this.lblWaybillNo.TabIndex = 56;
            this.lblWaybillNo.Text = "İrsaliye No.";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(19, 89);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(46, 13);
            this.labelControl13.TabIndex = 54;
            this.labelControl13.Text = "Evrak Tipi";
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.Location = new System.Drawing.Point(73, 86);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbInvoiceType.Size = new System.Drawing.Size(146, 20);
            this.cmbInvoiceType.TabIndex = 1;
            this.cmbInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cmbInvoiceType_SelectedIndexChanged);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(821, 171);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Properties.MaxLength = 50;
            this.txtOrderNo.Size = new System.Drawing.Size(156, 20);
            this.txtOrderNo.TabIndex = 14;
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Location = new System.Drawing.Point(764, 174);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(51, 13);
            this.lblOrderNo.TabIndex = 52;
            this.lblOrderNo.Text = "Sipariş No.";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Location = new System.Drawing.Point(771, 148);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(44, 13);
            this.lblOrderDate.TabIndex = 50;
            this.lblOrderDate.Text = "Sip.Tarihi";
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.Location = new System.Drawing.Point(821, 119);
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Properties.MaxLength = 50;
            this.txtOrderedBy.Size = new System.Drawing.Size(156, 20);
            this.txtOrderedBy.TabIndex = 5;
            // 
            // lblOrderedBy
            // 
            this.lblOrderedBy.Location = new System.Drawing.Point(757, 122);
            this.lblOrderedBy.Name = "lblOrderedBy";
            this.lblOrderedBy.Size = new System.Drawing.Size(58, 13);
            this.lblOrderedBy.TabIndex = 48;
            this.lblOrderedBy.Text = "Sipariş Eden";
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(585, 171);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Properties.MaxLength = 50;
            this.txtRequest.Size = new System.Drawing.Size(151, 20);
            this.txtRequest.TabIndex = 13;
            // 
            // lblRequested
            // 
            this.lblRequested.Location = new System.Drawing.Point(523, 174);
            this.lblRequested.Name = "lblRequested";
            this.lblRequested.Size = new System.Drawing.Size(53, 13);
            this.lblRequested.TabIndex = 46;
            this.lblRequested.Text = "Talep Eden";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.EditValue = "18";
            this.txtTaxRate.Location = new System.Drawing.Point(309, 171);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(62, 20);
            this.txtTaxRate.TabIndex = 11;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(73, 119);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Properties.MaxLength = 3;
            this.txtSerie.Size = new System.Drawing.Size(146, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(585, 145);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Properties.MaxLength = 25;
            this.txtRefNo.Size = new System.Drawing.Size(151, 20);
            this.txtRefNo.TabIndex = 8;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(309, 119);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(194, 20);
            this.txtNo.TabIndex = 3;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.EditValue = "";
            this.cmbCustomers.Location = new System.Drawing.Point(309, 145);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.cmbCustomers.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.cmbCustomers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerCode", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Müşteri")});
            this.cmbCustomers.Properties.DisplayMember = "CustomerName";
            this.cmbCustomers.Properties.NullText = "";
            this.cmbCustomers.Properties.ValueMember = "CustomerId";
            this.cmbCustomers.Size = new System.Drawing.Size(194, 20);
            this.cmbCustomers.TabIndex = 7;
            this.cmbCustomers.DoubleClick += new System.EventHandler(this.CmbCustomers_DoubleClick);
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(73, 145);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Size = new System.Drawing.Size(146, 20);
            this.dtpDate.TabIndex = 6;
            // 
            // cmbWithholding
            // 
            this.cmbWithholding.Location = new System.Drawing.Point(451, 171);
            this.cmbWithholding.Name = "cmbWithholding";
            this.cmbWithholding.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cmbWithholding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbWithholding.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbWithholding.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbWithholding.Size = new System.Drawing.Size(52, 20);
            this.cmbWithholding.TabIndex = 12;
            // 
            // lblWithholding
            // 
            this.lblWithholding.Location = new System.Drawing.Point(377, 174);
            this.lblWithholding.Name = "lblWithholding";
            this.lblWithholding.Size = new System.Drawing.Size(68, 13);
            this.lblWithholding.TabIndex = 44;
            this.lblWithholding.Text = "Tevkifat Oranı";
            // 
            // lblTaxRate
            // 
            this.lblTaxRate.Location = new System.Drawing.Point(246, 174);
            this.lblTaxRate.Name = "lblTaxRate";
            this.lblTaxRate.Size = new System.Drawing.Size(56, 13);
            this.lblTaxRate.TabIndex = 43;
            this.lblTaxRate.Text = "K.D.V Oranı";
            // 
            // lblExpiry
            // 
            this.lblExpiry.Location = new System.Drawing.Point(525, 122);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(51, 13);
            this.lblExpiry.TabIndex = 42;
            this.lblExpiry.Text = "Vade(Gün)";
            // 
            // lblRefNo
            // 
            this.lblRefNo.Location = new System.Drawing.Point(542, 148);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(34, 13);
            this.lblRefNo.TabIndex = 41;
            this.lblRefNo.Text = "Ref.No";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(11, 148);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 13);
            this.lblDate.TabIndex = 40;
            this.lblDate.Text = "Evrak Tarihi";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Location = new System.Drawing.Point(267, 148);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(35, 13);
            this.lblCustomer.TabIndex = 39;
            this.lblCustomer.Text = "Müşteri";
            // 
            // lblNo
            // 
            this.lblNo.Location = new System.Drawing.Point(255, 122);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(47, 13);
            this.lblNo.TabIndex = 38;
            this.lblNo.Text = "Evrak No.";
            // 
            // lblSerie
            // 
            this.lblSerie.Location = new System.Drawing.Point(19, 122);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(48, 13);
            this.lblSerie.TabIndex = 37;
            this.lblSerie.Text = "Evrak Seri";
            // 
            // barForNew
            // 
            this.barForNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.barForNew.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.barForNew.Groups.Add(this.tileBarGroup2);
            this.barForNew.ItemSize = 40;
            this.barForNew.Location = new System.Drawing.Point(0, 0);
            this.barForNew.MaxId = 6;
            this.barForNew.Name = "barForNew";
            this.barForNew.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.barForNew.Size = new System.Drawing.Size(992, 80);
            this.barForNew.TabIndex = 33;
            this.barForNew.Text = "tileBar1";
            this.barForNew.WideTileWidth = 130;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tbtnSave);
            this.tileBarGroup2.Items.Add(this.tbtnPrint);
            this.tileBarGroup2.Items.Add(this.tbtnDesign);
            this.tileBarGroup2.Items.Add(this.tbtnAttachments);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tbtnSave
            // 
            this.tbtnSave.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnSave.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnSave.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnSave.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnSave.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnSave.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnSave.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnSave.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnSave.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Kaydet";
            this.tbtnSave.Elements.Add(tileItemElement1);
            this.tbtnSave.Id = 0;
            this.tbtnSave.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnSave_ItemClick);
            // 
            // tbtnPrint
            // 
            this.tbtnPrint.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnPrint.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnPrint.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnPrint.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnPrint.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnPrint.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnPrint.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnPrint.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnPrint.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Yazdır";
            this.tbtnPrint.Elements.Add(tileItemElement2);
            this.tbtnPrint.Id = 4;
            this.tbtnPrint.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnPrint.Name = "tbtnPrint";
            this.tbtnPrint.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnPrint_ItemClick);
            // 
            // tbtnDesign
            // 
            this.tbtnDesign.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnDesign.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnDesign.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnDesign.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnDesign.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnDesign.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnDesign.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnDesign.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnDesign.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.Text = "Dizayn";
            this.tbtnDesign.Elements.Add(tileItemElement3);
            this.tbtnDesign.Id = 3;
            this.tbtnDesign.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnDesign.Name = "tbtnDesign";
            this.tbtnDesign.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnDesign_ItemClick);
            // 
            // grdBill
            // 
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdBill.Location = new System.Drawing.Point(0, 197);
            this.grdBill.MainView = this.vwBill;
            this.grdBill.Name = "grdBill";
            this.grdBill.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupProduct});
            this.grdBill.Size = new System.Drawing.Size(992, 329);
            this.grdBill.TabIndex = 15;
            this.grdBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwBill});
            // 
            // vwBill
            // 
            this.vwBill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct,
            this.colQuantity,
            this.colUnitPrice});
            this.vwBill.GridControl = this.grdBill;
            this.vwBill.Name = "vwBill";
            this.vwBill.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.vwBill.OptionsMenu.EnableGroupPanelMenu = false;
            this.vwBill.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.vwBill.OptionsMenu.ShowAutoFilterRowItem = false;
            this.vwBill.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.vwBill.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct
            // 
            this.colProduct.Caption = "Ürün";
            this.colProduct.ColumnEdit = this.lookupProduct;
            this.colProduct.FieldName = "ProductId";
            this.colProduct.Name = "colProduct";
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // lookupProduct
            // 
            this.lookupProduct.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.lookupProduct.AutoHeight = false;
            this.lookupProduct.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupProduct.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Ürün"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductDescription", "Açıklama")});
            this.lookupProduct.DisplayMember = "ProductName";
            this.lookupProduct.Name = "lookupProduct";
            this.lookupProduct.NullText = "";
            this.lookupProduct.ValueMember = "ProductId";
            this.lookupProduct.DoubleClick += new System.EventHandler(this.lookupProduct_DoubleClick);
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Miktar";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Birim Fiyat";
            this.colUnitPrice.DisplayFormat.FormatString = "{0:c2}";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(585, 119);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(151, 20);
            this.dtpExpiry.TabIndex = 4;
            // 
            // tabBillList
            // 
            this.tabBillList.Caption = "Fatura Listesi";
            this.tabBillList.Controls.Add(this.gridBillList);
            this.tabBillList.Controls.Add(this.barForList);
            this.tabBillList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabBillList.ImageOptions.Image")));
            this.tabBillList.Name = "tabBillList";
            this.tabBillList.Size = new System.Drawing.Size(992, 526);
            // 
            // gridBillList
            // 
            this.gridBillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBillList.Location = new System.Drawing.Point(0, 79);
            this.gridBillList.MainView = this.vwBillList;
            this.gridBillList.Name = "gridBillList";
            this.gridBillList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookupCustomer,
            this.grdcmbTypes});
            this.gridBillList.Size = new System.Drawing.Size(992, 447);
            this.gridBillList.TabIndex = 1;
            this.gridBillList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwBillList});
            // 
            // vwBillList
            // 
            this.vwBillList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBillDate,
            this.colType,
            this.colSerie,
            this.colNo,
            this.colCustomer,
            this.colExpiry,
            this.colTaxRate,
            this.colWithholding,
            this.colTaxAmount,
            this.colTotal,
            this.colTotalWithTax});
            this.vwBillList.GridControl = this.gridBillList;
            this.vwBillList.Name = "vwBillList";
            this.vwBillList.OptionsBehavior.ReadOnly = true;
            this.vwBillList.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Fast;
            this.vwBillList.OptionsView.ShowAutoFilterRow = true;
            this.vwBillList.OptionsView.ShowFooter = true;
            this.vwBillList.PrintInitialize += new DevExpress.XtraGrid.Views.Base.PrintInitializeEventHandler(this.VwBillList_PrintInitialize);
            // 
            // colBillDate
            // 
            this.colBillDate.Caption = "Tarih";
            this.colBillDate.FieldName = "InvoiceDate";
            this.colBillDate.Name = "colBillDate";
            this.colBillDate.OptionsColumn.AllowEdit = false;
            this.colBillDate.OptionsColumn.AllowFocus = false;
            this.colBillDate.Visible = true;
            this.colBillDate.VisibleIndex = 0;
            // 
            // colType
            // 
            this.colType.Caption = "Fatura Tipi";
            this.colType.ColumnEdit = this.grdcmbTypes;
            this.colType.FieldName = "InvoiceType";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowEdit = false;
            this.colType.OptionsColumn.AllowFocus = false;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            this.colType.Width = 80;
            // 
            // grdcmbTypes
            // 
            this.grdcmbTypes.AutoHeight = false;
            this.grdcmbTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdcmbTypes.DisplayMember = "Value";
            this.grdcmbTypes.Name = "grdcmbTypes";
            this.grdcmbTypes.NullText = "";
            this.grdcmbTypes.ValueMember = "Key";
            // 
            // colSerie
            // 
            this.colSerie.Caption = "Seri";
            this.colSerie.FieldName = "Serie";
            this.colSerie.Name = "colSerie";
            this.colSerie.OptionsColumn.AllowEdit = false;
            this.colSerie.OptionsColumn.AllowFocus = false;
            this.colSerie.Visible = true;
            this.colSerie.VisibleIndex = 2;
            // 
            // colNo
            // 
            this.colNo.Caption = "Sıra";
            this.colNo.FieldName = "Number";
            this.colNo.Name = "colNo";
            this.colNo.OptionsColumn.AllowEdit = false;
            this.colNo.OptionsColumn.AllowFocus = false;
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 3;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Müşteri";
            this.colCustomer.ColumnEdit = this.lookupCustomer;
            this.colCustomer.FieldName = "CustomerId";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.OptionsColumn.AllowEdit = false;
            this.colCustomer.OptionsColumn.AllowFocus = false;
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 4;
            this.colCustomer.Width = 183;
            // 
            // lookupCustomer
            // 
            this.lookupCustomer.AutoHeight = false;
            this.lookupCustomer.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookupCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupCustomer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Müşteri")});
            this.lookupCustomer.DisplayMember = "CustomerName";
            this.lookupCustomer.Name = "lookupCustomer";
            this.lookupCustomer.NullText = "";
            this.lookupCustomer.ValueMember = "CustomerId";
            // 
            // colExpiry
            // 
            this.colExpiry.Caption = "Vade";
            this.colExpiry.FieldName = "ExpiryPeriod";
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.OptionsColumn.AllowEdit = false;
            this.colExpiry.OptionsColumn.AllowFocus = false;
            this.colExpiry.Visible = true;
            this.colExpiry.VisibleIndex = 5;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "K.D.V Oranı";
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.OptionsColumn.AllowEdit = false;
            this.colTaxRate.OptionsColumn.AllowFocus = false;
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 6;
            // 
            // colWithholding
            // 
            this.colWithholding.Caption = "Tevkifat";
            this.colWithholding.FieldName = "WithholdingRate";
            this.colWithholding.Name = "colWithholding";
            this.colWithholding.OptionsColumn.AllowEdit = false;
            this.colWithholding.OptionsColumn.AllowFocus = false;
            this.colWithholding.Visible = true;
            this.colWithholding.VisibleIndex = 7;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.Caption = "K.D.V";
            this.colTaxAmount.DisplayFormat.FormatString = "{0:c2}";
            this.colTaxAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmount.FieldName = "colTaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.OptionsColumn.AllowEdit = false;
            this.colTaxAmount.OptionsColumn.AllowFocus = false;
            this.colTaxAmount.UnboundExpression = "Iif([WithholdingRate] = 0, [TaxAmount], [TaxAmount] / 10 * (10 - [WithholdingRate" +
    "]))";
            this.colTaxAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 8;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Net Tutar";
            this.colTotal.DisplayFormat.FormatString = "{0:c2}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "TotalAmount";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsColumn.AllowFocus = false;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "{0:c2}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            // 
            // colTotalWithTax
            // 
            this.colTotalWithTax.Caption = "Tutar";
            this.colTotalWithTax.DisplayFormat.FormatString = "{0:c2}";
            this.colTotalWithTax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalWithTax.FieldName = "colTotalWithTax";
            this.colTotalWithTax.Name = "colTotalWithTax";
            this.colTotalWithTax.OptionsColumn.AllowEdit = false;
            this.colTotalWithTax.OptionsColumn.AllowFocus = false;
            this.colTotalWithTax.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colTotalWithTax", "{0:c2}")});
            this.colTotalWithTax.UnboundExpression = "[TotalAmount] + [colTaxAmount]";
            this.colTotalWithTax.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotalWithTax.Visible = true;
            this.colTotalWithTax.VisibleIndex = 10;
            // 
            // barForList
            // 
            this.barForList.Dock = System.Windows.Forms.DockStyle.Top;
            this.barForList.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.barForList.Groups.Add(this.tileBarGroup3);
            this.barForList.ItemSize = 44;
            this.barForList.Location = new System.Drawing.Point(0, 0);
            this.barForList.MaxId = 2;
            this.barForList.Name = "barForList";
            this.barForList.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.barForList.Size = new System.Drawing.Size(992, 79);
            this.barForList.TabIndex = 0;
            // 
            // tileBarGroup3
            // 
            this.tileBarGroup3.Items.Add(this.tbtnGoTo);
            this.tileBarGroup3.Items.Add(this.tbtnPrintList);
            this.tileBarGroup3.Name = "tileBarGroup3";
            // 
            // tbtnGoTo
            // 
            this.tbtnGoTo.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnGoTo.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnGoTo.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnGoTo.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnGoTo.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnGoTo.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnGoTo.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnGoTo.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnGoTo.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.Text = "Seçili Evrağa Git";
            this.tbtnGoTo.Elements.Add(tileItemElement5);
            this.tbtnGoTo.Id = 0;
            this.tbtnGoTo.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnGoTo.Name = "tbtnGoTo";
            this.tbtnGoTo.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnGoTo_ItemClick);
            // 
            // tbtnPrintList
            // 
            this.tbtnPrintList.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnPrintList.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnPrintList.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnPrintList.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnPrintList.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnPrintList.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnPrintList.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnPrintList.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnPrintList.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "Listeyi Yazdır";
            this.tbtnPrintList.Elements.Add(tileItemElement6);
            this.tbtnPrintList.Id = 1;
            this.tbtnPrintList.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnPrintList.Name = "tbtnPrintList";
            this.tbtnPrintList.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbtnPrintList_ItemClick);
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabBillList);
            this.tabPanel.Controls.Add(this.tabNewBill);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPanel.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabBillList,
            this.tabNewBill});
            this.tabPanel.RegularSize = new System.Drawing.Size(992, 572);
            this.tabPanel.SelectedPage = this.tabBillList;
            this.tabPanel.Size = new System.Drawing.Size(992, 572);
            this.tabPanel.TabIndex = 37;
            this.tabPanel.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPanel_SelectedPageChanged);
            // 
            // tbtnAttachments
            // 
            this.tbtnAttachments.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnAttachments.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnAttachments.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnAttachments.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnAttachments.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnAttachments.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnAttachments.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnAttachments.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnAttachments.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Ekler";
            this.tbtnAttachments.Elements.Add(tileItemElement4);
            this.tbtnAttachments.Id = 5;
            this.tbtnAttachments.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnAttachments.Name = "tbtnAttachments";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 572);
            this.Controls.Add(this.tabPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Activated += new System.EventHandler(this.FrmInvoice_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBill_FormClosed);
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repocmbWithholding)).EndInit();
            this.tabNewBill.ResumeLayout(false);
            this.tabNewBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWaybillNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWithholding.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExpiry.Properties)).EndInit();
            this.tabBillList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBillList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwBillList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdcmbTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPanel)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repocmbWithholding;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNewBill;
        private DevExpress.XtraEditors.TextEdit txtTaxRate;
        private DevExpress.XtraEditors.TextEdit txtSerie;
        private DevExpress.XtraEditors.TextEdit txtRefNo;
        private DevExpress.XtraEditors.TextEdit txtNo;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomers;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private DevExpress.XtraEditors.ComboBoxEdit cmbWithholding;
        private DevExpress.XtraEditors.LabelControl lblWithholding;
        private DevExpress.XtraEditors.LabelControl lblTaxRate;
        private DevExpress.XtraEditors.LabelControl lblExpiry;
        private DevExpress.XtraEditors.LabelControl lblRefNo;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblCustomer;
        private DevExpress.XtraEditors.LabelControl lblNo;
        private DevExpress.XtraEditors.LabelControl lblSerie;
        private DevExpress.XtraBars.Navigation.TileBar barForNew;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnSave;
        private DevExpress.XtraGrid.GridControl grdBill;
        private DevExpress.XtraGrid.Views.Grid.GridView vwBill;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabBillList;
        private DevExpress.XtraGrid.GridControl gridBillList;
        private DevExpress.XtraBars.Navigation.TileBar barForList;
        private DevExpress.XtraBars.Navigation.TabPane tabPanel;
        private DevExpress.XtraGrid.Views.Grid.GridView vwBillList;
        private DevExpress.XtraGrid.Columns.GridColumn colBillDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSerie;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiry;
        private DevExpress.XtraGrid.Columns.GridColumn colWithholding;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookupCustomer;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup3;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnGoTo;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnDesign;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalWithTax;
        private DevExpress.XtraEditors.TextEdit dtpExpiry;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.ComboBoxEdit cmbInvoiceType;
        private DevExpress.XtraEditors.TextEdit txtOrderNo;
        private DevExpress.XtraEditors.LabelControl lblOrderNo;
        private DevExpress.XtraEditors.LabelControl lblOrderDate;
        private DevExpress.XtraEditors.TextEdit txtOrderedBy;
        private DevExpress.XtraEditors.LabelControl lblOrderedBy;
        private DevExpress.XtraEditors.TextEdit txtRequest;
        private DevExpress.XtraEditors.LabelControl lblRequested;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnPrintList;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit grdcmbTypes;
        private DevExpress.XtraEditors.TextEdit txtWaybillNo;
        private DevExpress.XtraEditors.LabelControl lblWaybillNo;
        private DevExpress.XtraEditors.DateEdit dtpOrderDate;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnAttachments;
    }
}