namespace IsKaiser.Management.WinUI.Forms
{
    partial class frmNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewUser));
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblUserType = new DevExpress.XtraEditors.LabelControl();
            this.cmbUserType = new DevExpress.XtraEditors.LookUpEdit();
            this.lblEmployee = new DevExpress.XtraEditors.LabelControl();
            this.cmbEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbUserName = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(27, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı :";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(42, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(29, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblUserType
            // 
            this.lblUserType.Location = new System.Drawing.Point(8, 94);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(63, 13);
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "Kullanıcı Tipi :";
            // 
            // cmbUserType
            // 
            this.cmbUserType.Location = new System.Drawing.Point(77, 91);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserType.Properties.DropDownRows = 3;
            this.cmbUserType.Properties.NullText = "";
            this.cmbUserType.Size = new System.Drawing.Size(165, 20);
            this.cmbUserType.TabIndex = 5;
            this.cmbUserType.EditValueChanged += new System.EventHandler(this.cmbUserType_EditValueChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.Location = new System.Drawing.Point(26, 120);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(45, 13);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Kime Ait :";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Location = new System.Drawing.Point(77, 117);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmployee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeCode", "Kod"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "İsim"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeLastName", "Soyisim")});
            this.cmbEmployee.Properties.DropDownRows = 5;
            this.cmbEmployee.Properties.NullText = "";
            this.cmbEmployee.Size = new System.Drawing.Size(165, 20);
            this.cmbEmployee.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(157, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbUserName
            // 
            this.cmbUserName.Location = new System.Drawing.Point(77, 39);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserName.Properties.NullText = "";
            this.cmbUserName.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.cmbUserName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbUserName.Size = new System.Drawing.Size(165, 20);
            this.cmbUserName.TabIndex = 1;
            this.cmbUserName.EditValueChanged += new System.EventHandler(this.cmbUserName_EditValueChanged);
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 203);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ekle/Güncelle";
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblUserType;
        private DevExpress.XtraEditors.LookUpEdit cmbUserType;
        private DevExpress.XtraEditors.LabelControl lblEmployee;
        private DevExpress.XtraEditors.LookUpEdit cmbEmployee;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LookUpEdit cmbUserName;
    }
}