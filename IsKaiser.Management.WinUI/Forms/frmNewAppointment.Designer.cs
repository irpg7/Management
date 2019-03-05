namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmNewAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewAppointment));
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnSave = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.grpAppointment = new DevExpress.XtraEditors.GroupControl();
            this.dtpAppoinmentDate = new DevExpress.XtraEditors.DateEdit();
            this.cmbEnvoy = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAppointmentDetail = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAppointment)).BeginInit();
            this.grpAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAppoinmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAppoinmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnvoy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppointmentDetail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemSize = 40;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 1;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(609, 65);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.WideTileWidth = 110;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tbtnSave);
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
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Kaydet";
            this.tbtnSave.Elements.Add(tileItemElement1);
            this.tbtnSave.Id = 0;
            this.tbtnSave.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbtnSave_ItemClick);
            // 
            // grpAppointment
            // 
            this.grpAppointment.Controls.Add(this.dtpAppoinmentDate);
            this.grpAppointment.Controls.Add(this.cmbEnvoy);
            this.grpAppointment.Controls.Add(this.txtAppointmentDetail);
            this.grpAppointment.Location = new System.Drawing.Point(12, 72);
            this.grpAppointment.Name = "grpAppointment";
            this.grpAppointment.Size = new System.Drawing.Size(585, 415);
            this.grpAppointment.TabIndex = 1;
            this.grpAppointment.Text = "Randevu";
            // 
            // dtpAppoinmentDate
            // 
            this.dtpAppoinmentDate.EditValue = null;
            this.dtpAppoinmentDate.Location = new System.Drawing.Point(302, 52);
            this.dtpAppoinmentDate.Name = "dtpAppoinmentDate";
            this.dtpAppoinmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpAppoinmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpAppoinmentDate.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dtpAppoinmentDate.Properties.ContextImageOptions.Image")));
            this.dtpAppoinmentDate.Size = new System.Drawing.Size(183, 20);
            this.dtpAppoinmentDate.TabIndex = 2;
            // 
            // cmbEnvoy
            // 
            this.cmbEnvoy.Location = new System.Drawing.Point(78, 52);
            this.cmbEnvoy.Name = "cmbEnvoy";
            this.cmbEnvoy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEnvoy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeCode", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Ad"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeLastName", "Soyad")});
            this.cmbEnvoy.Properties.DropDownRows = 5;
            this.cmbEnvoy.Properties.NullText = "";
            this.cmbEnvoy.Size = new System.Drawing.Size(171, 20);
            this.cmbEnvoy.TabIndex = 1;
            // 
            // txtAppointmentDetail
            // 
            this.txtAppointmentDetail.Location = new System.Drawing.Point(0, 103);
            this.txtAppointmentDetail.Name = "txtAppointmentDetail";
            this.txtAppointmentDetail.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAppointmentDetail.Size = new System.Drawing.Size(585, 312);
            this.txtAppointmentDetail.TabIndex = 0;
            // 
            // frmNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 499);
            this.Controls.Add(this.grpAppointment);
            this.Controls.Add(this.tileBar1);
            this.Name = "frmNewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Randevu";
            this.Load += new System.EventHandler(this.frmNewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpAppointment)).EndInit();
            this.grpAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpAppoinmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpAppoinmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnvoy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppointmentDetail.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnSave;
        private DevExpress.XtraEditors.GroupControl grpAppointment;
        private DevExpress.XtraEditors.DateEdit dtpAppoinmentDate;
        private DevExpress.XtraEditors.LookUpEdit cmbEnvoy;
        private DevExpress.XtraEditors.MemoEdit txtAppointmentDetail;
    }
}