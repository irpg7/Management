using DevExpress.XtraEditors;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.WinUI.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;


namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmNewUser : XtraForm
    {
        public frmNewUser()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        IUserService _userService;
        IEmployeeService _employeeService;
        int userId;
        private void frmNewUser_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadUserTypes();
            LoadUsers();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                if (userId==0)
                {
                    var userToAdd = new User
                    {
                        UserName = cmbUserName.Text,
                        UserPw = txtPassword.Text,
                        UserType = Convert.ToByte(cmbUserType.EditValue),
                        EmployeeId = Convert.ToInt32(cmbEmployee.EditValue)
                    };
                    _userService.Add(userToAdd);
                    XtraMessageBox.Show("Kullanıcı Eklendi.");
                }
                else
                {
                    var userToUpdate = new User
                    {
                        UserId=userId,
                        UserName = cmbUserName.Text,
                        UserPw = txtPassword.Text,
                        UserType = Convert.ToByte(cmbUserType.EditValue),
                        EmployeeId = Convert.ToInt32(cmbEmployee.EditValue)
                    };
                    _userService.Update(userToUpdate);
                    XtraMessageBox.Show("Kullanıcı Güncellendi.");
                }
                LoadUsers();
            });

        }
        void LoadUsers()
        {
            cmbUserName.Properties.DataSource = _userService.GetAll();
            cmbUserName.Properties.DisplayMember = "UserName";
            cmbUserName.Properties.ValueMember = "UserName";
            cmbUserName.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UserName", "Kullanıcı"));

        }
        void LoadEmployees()
        {
            cmbEmployee.Properties.DataSource = _employeeService.GetAll();
            cmbEmployee.Properties.DisplayMember = "EmployeeName";
            cmbEmployee.Properties.ValueMember = "EmployeeId";
        }
        void LoadUserTypes()
        {
            Dictionary<int, string> userTypes = new Dictionary<int, string>();
            userTypes.Add(1, "Yönetici");
            userTypes.Add(2, "Kullanıcı");
            cmbUserType.Properties.DataSource = userTypes;
           
        }

        private void cmbUserType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbUserName_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbUserName.EditValue != cmbUserName.Properties.GetKeyValueByDisplayValue(cmbUserName.EditValue))
            {

                userId = 0;
                txtPassword.ResetText();
                cmbEmployee.EditValue = -1;
                cmbUserType.EditValue = -1;
            }
            else
            {
                userId = (int)cmbUserName.GetColumnValue("UserId");
                var userDetails = _userService.Get(userId);
                txtPassword.Text = userDetails.UserPw;
                cmbEmployee.EditValue = userDetails.EmployeeId;
                cmbUserType.EditValue = (int)userDetails.UserType;
            }
        }
    }
}