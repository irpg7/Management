namespace IsKaiser.Management.WinUI.Forms
{
    partial class FrmCompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyInfo));
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnSave = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxNo = new DevExpress.XtraEditors.TextEdit();
            this.txtTaxDepartment = new DevExpress.XtraEditors.TextEdit();
            this.lblTaxDepartment = new DevExpress.XtraEditors.LabelControl();
            this.lblTaxNo = new DevExpress.XtraEditors.LabelControl();
            this.txtBankName = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            this.lblBankName = new DevExpress.XtraEditors.LabelControl();
            this.txtTLIban = new DevExpress.XtraEditors.TextEdit();
            this.txtBranchOffice = new DevExpress.XtraEditors.TextEdit();
            this.lblBranchOffice = new DevExpress.XtraEditors.LabelControl();
            this.lblTLIban = new DevExpress.XtraEditors.LabelControl();
            this.txtDolarIban = new DevExpress.XtraEditors.TextEdit();
            this.txtEuroIban = new DevExpress.XtraEditors.TextEdit();
            this.lblEuroIban = new DevExpress.XtraEditors.LabelControl();
            this.lblDolarIban = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTLIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDolarIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEuroIban.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.GroupTextToItemsIndent = 0;
            this.tileBar1.ItemSize = 56;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 2;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(22, 0, 22, 7);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(901, 78);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
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
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.Text = "Kaydet";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbtnSave.Elements.Add(tileItemElement1);
            this.tbtnSave.Id = 0;
            this.tbtnSave.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnSave.Name = "tbtnSave";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(13, 41);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(44, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Firma Adı";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(14, 77);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(28, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Adres";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(97, 38);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(394, 20);
            this.txtCompanyName.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDolarIban);
            this.groupControl1.Controls.Add(this.txtEuroIban);
            this.groupControl1.Controls.Add(this.lblEuroIban);
            this.groupControl1.Controls.Add(this.lblDolarIban);
            this.groupControl1.Controls.Add(this.txtTLIban);
            this.groupControl1.Controls.Add(this.txtBranchOffice);
            this.groupControl1.Controls.Add(this.lblBranchOffice);
            this.groupControl1.Controls.Add(this.lblTLIban);
            this.groupControl1.Controls.Add(this.txtBankName);
            this.groupControl1.Controls.Add(this.txtPhone);
            this.groupControl1.Controls.Add(this.lblPhone);
            this.groupControl1.Controls.Add(this.lblBankName);
            this.groupControl1.Controls.Add(this.txtTaxNo);
            this.groupControl1.Controls.Add(this.txtTaxDepartment);
            this.groupControl1.Controls.Add(this.lblTaxDepartment);
            this.groupControl1.Controls.Add(this.lblTaxNo);
            this.groupControl1.Controls.Add(this.txtAddress);
            this.groupControl1.Controls.Add(this.txtCompanyName);
            this.groupControl1.Controls.Add(this.lblCompanyName);
            this.groupControl1.Controls.Add(this.lblAddress);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(0, 78);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(901, 247);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Firma Bilgileri";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(97, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(394, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.Location = new System.Drawing.Point(97, 150);
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Size = new System.Drawing.Size(394, 20);
            this.txtTaxNo.TabIndex = 8;
            // 
            // txtTaxDepartment
            // 
            this.txtTaxDepartment.Location = new System.Drawing.Point(97, 114);
            this.txtTaxDepartment.Name = "txtTaxDepartment";
            this.txtTaxDepartment.Size = new System.Drawing.Size(394, 20);
            this.txtTaxDepartment.TabIndex = 7;
            // 
            // lblTaxDepartment
            // 
            this.lblTaxDepartment.Location = new System.Drawing.Point(13, 117);
            this.lblTaxDepartment.Name = "lblTaxDepartment";
            this.lblTaxDepartment.Size = new System.Drawing.Size(59, 13);
            this.lblTaxDepartment.TabIndex = 5;
            this.lblTaxDepartment.Text = "Vergi Dairesi";
            // 
            // lblTaxNo
            // 
            this.lblTaxNo.Location = new System.Drawing.Point(14, 153);
            this.lblTaxNo.Name = "lblTaxNo";
            this.lblTaxNo.Size = new System.Drawing.Size(44, 13);
            this.lblTaxNo.TabIndex = 6;
            this.lblTaxNo.Text = "Vergi No.";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(639, 38);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(233, 20);
            this.txtBankName.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(97, 191);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(394, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(13, 194);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(36, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Telefon";
            // 
            // lblBankName
            // 
            this.lblBankName.Location = new System.Drawing.Point(556, 41);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(47, 13);
            this.lblBankName.TabIndex = 10;
            this.lblBankName.Text = "Banka Adı";
            // 
            // txtTLIban
            // 
            this.txtTLIban.Location = new System.Drawing.Point(639, 111);
            this.txtTLIban.Name = "txtTLIban";
            this.txtTLIban.Size = new System.Drawing.Size(233, 20);
            this.txtTLIban.TabIndex = 16;
            // 
            // txtBranchOffice
            // 
            this.txtBranchOffice.Location = new System.Drawing.Point(639, 75);
            this.txtBranchOffice.Name = "txtBranchOffice";
            this.txtBranchOffice.Size = new System.Drawing.Size(233, 20);
            this.txtBranchOffice.TabIndex = 15;
            // 
            // lblBranchOffice
            // 
            this.lblBranchOffice.Location = new System.Drawing.Point(555, 78);
            this.lblBranchOffice.Name = "lblBranchOffice";
            this.lblBranchOffice.Size = new System.Drawing.Size(63, 13);
            this.lblBranchOffice.TabIndex = 13;
            this.lblBranchOffice.Text = "Banka Şubesi";
            // 
            // lblTLIban
            // 
            this.lblTLIban.Location = new System.Drawing.Point(556, 114);
            this.lblTLIban.Name = "lblTLIban";
            this.lblTLIban.Size = new System.Drawing.Size(38, 13);
            this.lblTLIban.TabIndex = 14;
            this.lblTLIban.Text = "TL IBAN";
            // 
            // txtDolarIban
            // 
            this.txtDolarIban.Location = new System.Drawing.Point(639, 191);
            this.txtDolarIban.Name = "txtDolarIban";
            this.txtDolarIban.Size = new System.Drawing.Size(233, 20);
            this.txtDolarIban.TabIndex = 20;
            // 
            // txtEuroIban
            // 
            this.txtEuroIban.Location = new System.Drawing.Point(639, 151);
            this.txtEuroIban.Name = "txtEuroIban";
            this.txtEuroIban.Size = new System.Drawing.Size(233, 20);
            this.txtEuroIban.TabIndex = 19;
            // 
            // lblEuroIban
            // 
            this.lblEuroIban.Location = new System.Drawing.Point(555, 154);
            this.lblEuroIban.Name = "lblEuroIban";
            this.lblEuroIban.Size = new System.Drawing.Size(49, 13);
            this.lblEuroIban.TabIndex = 17;
            this.lblEuroIban.Text = "Euro IBAN";
            // 
            // lblDolarIban
            // 
            this.lblDolarIban.Location = new System.Drawing.Point(555, 194);
            this.lblDolarIban.Name = "lblDolarIban";
            this.lblDolarIban.Size = new System.Drawing.Size(52, 13);
            this.lblDolarIban.TabIndex = 18;
            this.lblDolarIban.Text = "Dolar IBAN";
            // 
            // FrmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 325);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tileBar1);
            this.Name = "FrmCompanyInfo";
            this.Text = "Firma Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTLIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDolarIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEuroIban.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnSave;
        private DevExpress.XtraEditors.LabelControl lblCompanyName;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtDolarIban;
        private DevExpress.XtraEditors.TextEdit txtEuroIban;
        private DevExpress.XtraEditors.LabelControl lblEuroIban;
        private DevExpress.XtraEditors.LabelControl lblDolarIban;
        private DevExpress.XtraEditors.TextEdit txtTLIban;
        private DevExpress.XtraEditors.TextEdit txtBranchOffice;
        private DevExpress.XtraEditors.LabelControl lblBranchOffice;
        private DevExpress.XtraEditors.LabelControl lblTLIban;
        private DevExpress.XtraEditors.TextEdit txtBankName;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lblPhone;
        private DevExpress.XtraEditors.LabelControl lblBankName;
        private DevExpress.XtraEditors.TextEdit txtTaxNo;
        private DevExpress.XtraEditors.TextEdit txtTaxDepartment;
        private DevExpress.XtraEditors.LabelControl lblTaxDepartment;
        private DevExpress.XtraEditors.LabelControl lblTaxNo;
        private DevExpress.XtraEditors.TextEdit txtAddress;
    }
}