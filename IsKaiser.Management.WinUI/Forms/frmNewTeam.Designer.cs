namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmNewTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTeam));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblTeamName = new DevExpress.XtraEditors.LabelControl();
            this.lblTeamLeader = new DevExpress.XtraEditors.LabelControl();
            this.cmbTeamLeader = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTeamName = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeamLeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeamName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(157, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.Location = new System.Drawing.Point(22, 15);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(52, 13);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Takım Adı :";
            // 
            // lblTeamLeader
            // 
            this.lblTeamLeader.Location = new System.Drawing.Point(12, 50);
            this.lblTeamLeader.Name = "lblTeamLeader";
            this.lblTeamLeader.Size = new System.Drawing.Size(62, 13);
            this.lblTeamLeader.TabIndex = 3;
            this.lblTeamLeader.Text = "Takım Lideri :";
            // 
            // cmbTeamLeader
            // 
            this.cmbTeamLeader.Location = new System.Drawing.Point(95, 47);
            this.cmbTeamLeader.Name = "cmbTeamLeader";
            this.cmbTeamLeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTeamLeader.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeCode", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Ad"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeLastName", "Soyad")});
            this.cmbTeamLeader.Properties.NullText = "";
            this.cmbTeamLeader.Size = new System.Drawing.Size(147, 20);
            this.cmbTeamLeader.TabIndex = 4;
            // 
            // cmbTeamName
            // 
            this.cmbTeamName.Location = new System.Drawing.Point(95, 12);
            this.cmbTeamName.Name = "cmbTeamName";
            this.cmbTeamName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTeamName.Properties.NullText = "";
            this.cmbTeamName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.cmbTeamName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTeamName.Size = new System.Drawing.Size(147, 20);
            this.cmbTeamName.TabIndex = 2;
            this.cmbTeamName.EditValueChanged += new System.EventHandler(this.cmbTeamName_EditValueChanged);
            // 
            // frmNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 127);
            this.Controls.Add(this.lblTeamLeader);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTeamLeader);
            this.Controls.Add(this.cmbTeamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNewTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım Ekle/Güncelle";
            this.Load += new System.EventHandler(this.frmNewTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeamLeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTeamName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblTeamName;
        private DevExpress.XtraEditors.LabelControl lblTeamLeader;
        private DevExpress.XtraEditors.LookUpEdit cmbTeamLeader;
        private DevExpress.XtraEditors.LookUpEdit cmbTeamName;
    }
}