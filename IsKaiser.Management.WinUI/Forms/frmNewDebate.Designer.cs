namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmNewDebate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewDebate));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tbarGroup = new DevExpress.XtraBars.Navigation.TileBar();
            this.tbarCommonGroup = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnSave = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnPrint = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.grpGrsDetay = new DevExpress.XtraEditors.GroupControl();
            this.txtDetail = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtRequested = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpDate = new DevExpress.XtraEditors.DateEdit();
            this.txtSecurity = new DevExpress.XtraEditors.MemoEdit();
            this.txtEquipment = new DevExpress.XtraEditors.MemoEdit();
            this.cmbTeam = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrsDetay)).BeginInit();
            this.grpGrsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequested.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarGroup
            // 
            this.tbarGroup.AllowDrag = false;
            this.tbarGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbarGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbarGroup.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tbarGroup.Groups.Add(this.tbarCommonGroup);
            this.tbarGroup.ItemSize = 40;
            this.tbarGroup.Location = new System.Drawing.Point(0, 0);
            this.tbarGroup.MaxId = 5;
            this.tbarGroup.Name = "tbarGroup";
            this.tbarGroup.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.tbarGroup.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tbarGroup.Size = new System.Drawing.Size(640, 65);
            this.tbarGroup.TabIndex = 1;
            this.tbarGroup.Text = "tileBar1";
            this.tbarGroup.WideTileWidth = 110;
            // 
            // tbarCommonGroup
            // 
            this.tbarCommonGroup.Items.Add(this.tbtnSave);
            this.tbarCommonGroup.Items.Add(this.tbtnPrint);
            this.tbarCommonGroup.Name = "tbarCommonGroup";
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
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
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
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Yazdır";
            this.tbtnPrint.Elements.Add(tileItemElement2);
            this.tbtnPrint.Id = 4;
            this.tbtnPrint.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnPrint.Name = "tbtnPrint";
            this.tbtnPrint.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnPrint_ItemClick);
            // 
            // grpGrsDetay
            // 
            this.grpGrsDetay.Controls.Add(this.txtDetail);
            this.grpGrsDetay.Controls.Add(this.labelControl4);
            this.grpGrsDetay.Controls.Add(this.cmbEmployee);
            this.grpGrsDetay.Controls.Add(this.labelControl3);
            this.grpGrsDetay.Controls.Add(this.txtRequested);
            this.grpGrsDetay.Controls.Add(this.labelControl2);
            this.grpGrsDetay.Controls.Add(this.labelControl1);
            this.grpGrsDetay.Controls.Add(this.dtpDate);
            this.grpGrsDetay.Controls.Add(this.txtSecurity);
            this.grpGrsDetay.Controls.Add(this.txtEquipment);
            this.grpGrsDetay.Controls.Add(this.cmbTeam);
            this.grpGrsDetay.Location = new System.Drawing.Point(0, 71);
            this.grpGrsDetay.Name = "grpGrsDetay";
            this.grpGrsDetay.Size = new System.Drawing.Size(638, 431);
            this.grpGrsDetay.TabIndex = 13;
            this.grpGrsDetay.Text = "Görüşme Detayları";
            // 
            // txtDetail
            // 
            this.txtDetail.EditValue = "";
            this.txtDetail.Location = new System.Drawing.Point(317, 86);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetail.Size = new System.Drawing.Size(316, 139);
            this.txtDetail.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(317, 253);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Güvenlik Tedbirleri";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Location = new System.Drawing.Point(12, 23);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeCode", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "İsim"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeLastName", "Soyad")});
            this.cmbEmployee.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmbEmployee.Properties.ContextImageOptions.Image")));
            this.cmbEmployee.Properties.DropDownRows = 5;
            this.cmbEmployee.Properties.NullText = "";
            this.cmbEmployee.Size = new System.Drawing.Size(190, 20);
            this.cmbEmployee.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 253);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Ekipman ve Malzeme";
            // 
            // txtRequested
            // 
            this.txtRequested.EditValue = "";
            this.txtRequested.Location = new System.Drawing.Point(5, 86);
            this.txtRequested.Name = "txtRequested";
            this.txtRequested.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRequested.Size = new System.Drawing.Size(306, 139);
            this.txtRequested.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(317, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Çalışma Alanı Gerekli Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Talep Edilen";
            // 
            // dtpDate
            // 
            this.dtpDate.EditValue = null;
            this.dtpDate.Location = new System.Drawing.Point(227, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dtpDate.Properties.ContextImageOptions.Image")));
            this.dtpDate.Size = new System.Drawing.Size(190, 20);
            this.dtpDate.TabIndex = 2;
            // 
            // txtSecurity
            // 
            this.txtSecurity.EditValue = "";
            this.txtSecurity.Location = new System.Drawing.Point(317, 272);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecurity.Size = new System.Drawing.Size(316, 140);
            this.txtSecurity.TabIndex = 6;
            // 
            // txtEquipment
            // 
            this.txtEquipment.EditValue = "";
            this.txtEquipment.Location = new System.Drawing.Point(5, 272);
            this.txtEquipment.Name = "txtEquipment";
            this.txtEquipment.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquipment.Size = new System.Drawing.Size(306, 140);
            this.txtEquipment.TabIndex = 5;
            // 
            // cmbTeam
            // 
            this.cmbTeam.Location = new System.Drawing.Point(439, 23);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTeam.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TeamName", "Ekip Adı")});
            this.cmbTeam.Properties.DropDownRows = 5;
            this.cmbTeam.Properties.NullText = "";
            this.cmbTeam.Properties.PopupSizeable = false;
            this.cmbTeam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTeam.Size = new System.Drawing.Size(189, 20);
            this.cmbTeam.TabIndex = 12;
            // 
            // frmNewDebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 505);
            this.Controls.Add(this.grpGrsDetay);
            this.Controls.Add(this.tbarGroup);
            this.Name = "frmNewDebate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüşme";
            this.Load += new System.EventHandler(this.frmNewDebate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrsDetay)).EndInit();
            this.grpGrsDetay.ResumeLayout(false);
            this.grpGrsDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequested.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecurity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquipment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tbarGroup;
        private DevExpress.XtraBars.Navigation.TileBarGroup tbarCommonGroup;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnSave;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnPrint;
        private DevExpress.XtraEditors.GroupControl grpGrsDetay;
        private DevExpress.XtraEditors.MemoEdit txtDetail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cmbEmployee;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtRequested;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtpDate;
        private DevExpress.XtraEditors.MemoEdit txtSecurity;
        private DevExpress.XtraEditors.MemoEdit txtEquipment;
        private DevExpress.XtraEditors.LookUpEdit cmbTeam;
    }
}