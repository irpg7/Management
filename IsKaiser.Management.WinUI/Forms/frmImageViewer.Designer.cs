namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmImageViewer
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImageViewer));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.TbarImageOperations = new DevExpress.XtraBars.Navigation.TileBar();
            this.TbarGroupOperations = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbtnPrevious = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnNext = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbtnShowInFolder = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.picFrame = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrame.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TbarImageOperations
            // 
            this.TbarImageOperations.AllowSelectedItemBorder = false;
            this.TbarImageOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbarImageOperations.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.TbarImageOperations.Groups.Add(this.TbarGroupOperations);
            this.TbarImageOperations.ItemSize = 45;
            this.TbarImageOperations.Location = new System.Drawing.Point(0, 0);
            this.TbarImageOperations.MaxId = 3;
            this.TbarImageOperations.Name = "TbarImageOperations";
            this.TbarImageOperations.Padding = new System.Windows.Forms.Padding(22, 0, 22, 7);
            this.TbarImageOperations.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.TbarImageOperations.SelectionBorderWidth = 0;
            this.TbarImageOperations.SelectionColor = System.Drawing.Color.Transparent;
            this.TbarImageOperations.Size = new System.Drawing.Size(1073, 64);
            this.TbarImageOperations.TabIndex = 0;
            this.TbarImageOperations.TabStop = false;
            this.TbarImageOperations.Text = "tileBar1";
            this.TbarImageOperations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbarImageOperations_KeyDown);
            // 
            // TbarGroupOperations
            // 
            this.TbarGroupOperations.Items.Add(this.tbtnPrevious);
            this.TbarGroupOperations.Items.Add(this.tbtnNext);
            this.TbarGroupOperations.Items.Add(this.tbtnShowInFolder);
            this.TbarGroupOperations.Name = "TbarGroupOperations";
            // 
            // tbtnPrevious
            // 
            this.tbtnPrevious.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnPrevious.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnPrevious.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnPrevious.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnPrevious.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnPrevious.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnPrevious.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnPrevious.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnPrevious.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Önceki";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbtnPrevious.Elements.Add(tileItemElement4);
            this.tbtnPrevious.Id = 0;
            this.tbtnPrevious.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnPrevious.Name = "tbtnPrevious";
            this.tbtnPrevious.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbtnPrevious_ItemClick);
            // 
            // tbtnNext
            // 
            this.tbtnNext.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnNext.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnNext.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnNext.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnNext.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnNext.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnNext.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnNext.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnNext.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Right;
            tileItemElement5.Text = "Sonraki";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbtnNext.Elements.Add(tileItemElement5);
            this.tbtnNext.Id = 1;
            this.tbtnNext.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnNext.Name = "tbtnNext";
            this.tbtnNext.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbtnNext_ItemClick);
            // 
            // tbtnShowInFolder
            // 
            this.tbtnShowInFolder.AppearanceItem.Hovered.BackColor = System.Drawing.Color.LightGray;
            this.tbtnShowInFolder.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tbtnShowInFolder.AppearanceItem.Normal.BackColor = System.Drawing.Color.Transparent;
            this.tbtnShowInFolder.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbtnShowInFolder.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbtnShowInFolder.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbtnShowInFolder.AppearanceItem.Pressed.BackColor = System.Drawing.Color.Silver;
            this.tbtnShowInFolder.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tbtnShowInFolder.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement6.Text = "Dosya\'da Görüntüle";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tbtnShowInFolder.Elements.Add(tileItemElement6);
            this.tbtnShowInFolder.Id = 2;
            this.tbtnShowInFolder.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbtnShowInFolder.Name = "tbtnShowInFolder";
            this.tbtnShowInFolder.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.TbtnShowInFolder_ItemClick);
            // 
            // picFrame
            // 
            this.picFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFrame.Location = new System.Drawing.Point(0, 64);
            this.picFrame.Name = "picFrame";
            this.picFrame.Properties.ErrorImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("picFrame.Properties.ErrorImageOptions.Image")));
            this.picFrame.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picFrame.Size = new System.Drawing.Size(1073, 503);
            this.picFrame.TabIndex = 1;
            // 
            // frmImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 567);
            this.Controls.Add(this.picFrame);
            this.Controls.Add(this.TbarImageOperations);
            this.Name = "frmImageViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotoğraf Görüntüleyici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrame.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar TbarImageOperations;
        private DevExpress.XtraEditors.PictureEdit picFrame;
        private DevExpress.XtraBars.Navigation.TileBarGroup TbarGroupOperations;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnPrevious;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnNext;
        private DevExpress.XtraBars.Navigation.TileBarItem tbtnShowInFolder;
    }
}