namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmProducts
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbProductType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtProductName = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.grpAddProduct = new DevExpress.XtraEditors.GroupControl();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnSave = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAddProduct)).BeginInit();
            this.grpAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürün Adı :";
            // 
            // cmbProductType
            // 
            this.cmbProductType.Location = new System.Drawing.Point(14, 157);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.cmbProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Tip")});
            this.cmbProductType.Properties.NullText = "";
            this.cmbProductType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cmbProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbProductType.Properties.UseReadOnlyAppearance = false;
            this.cmbProductType.Size = new System.Drawing.Size(292, 20);
            this.cmbProductType.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(14, 50);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.Size = new System.Drawing.Size(292, 68);
            this.txtProductName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ürün Tipi :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 205);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Ürün Açıklaması :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(14, 224);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(292, 124);
            this.txtDescription.TabIndex = 3;
            // 
            // grpAddProduct
            // 
            this.grpAddProduct.Controls.Add(this.txtDescription);
            this.grpAddProduct.Controls.Add(this.labelControl1);
            this.grpAddProduct.Controls.Add(this.labelControl3);
            this.grpAddProduct.Controls.Add(this.cmbProductType);
            this.grpAddProduct.Controls.Add(this.labelControl2);
            this.grpAddProduct.Controls.Add(this.txtProductName);
            this.grpAddProduct.Location = new System.Drawing.Point(0, 90);
            this.grpAddProduct.Name = "grpAddProduct";
            this.grpAddProduct.Size = new System.Drawing.Size(332, 376);
            this.grpAddProduct.TabIndex = 7;
            this.grpAddProduct.Text = "Ürün Ekle";
            // 
            // tileBar1
            // 
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemSize = 45;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 1;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(332, 84);
            this.tileBar1.TabIndex = 8;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.WideTileWidth = 133;
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
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Kaydet";
            this.tbtnSave.Elements.Add(tileItemElement2);
            this.tbtnSave.Id = 0;
            this.tbtnSave.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnSave.Name = "tbtnSave";
            this.tbtnSave.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbtnSave_ItemClick);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 468);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.grpAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAddProduct)).EndInit();
            this.grpAddProduct.ResumeLayout(false);
            this.grpAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cmbProductType;
        private DevExpress.XtraEditors.MemoEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.GroupControl grpAddProduct;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnSave;
    }
}