using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.WinUI.ExceptionHandling;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmNewEmployee : DevExpress.XtraEditors.XtraForm
    {
        public frmNewEmployee()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _employeeTeamService = InstanceFactory.GetInstance<IEmployeeTeamService>();
        }
        IEmployeeService _employeeService;
        IEmployeeTeamService _employeeTeamService;
        Employee getEmployeeDetails;
        int empId;
        private void btnSave_Click(object sender, EventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                if (empId==0)
                {
                    var employeeToAdd = new Employee
                    {
                        EmployeeCode = cmbCode.Text,
                        EmployeeName = txtName.Text,
                        EmployeeLastName = txtLastName.Text,
                        EmployeeTeamId = Convert.ToInt32(cmbTeam.EditValue)
                    };
                    _employeeService.Add(employeeToAdd);
                    XtraMessageBox.Show("Kaydedildi.");
                }
                else
                {
                    var employeeToUpdate = new Employee
                    {
                        EmployeeId = getEmployeeDetails.EmployeeId,
                        EmployeeCode = cmbCode.Text,
                        EmployeeName = txtName.Text,
                        EmployeeLastName = txtLastName.Text,
                        EmployeeTeamId = Convert.ToInt32(cmbTeam.EditValue)
                    };
                    _employeeService.Update(employeeToUpdate);
                    XtraMessageBox.Show("Güncellendi.");
                }
                LoadLookUps();
            });

        }

        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            LoadLookUps();
        }
        void LoadLookUps()
        {
            cmbTeam.Properties.DataSource = _employeeTeamService.GetAll();
            cmbTeam.Properties.DisplayMember = "TeamName";
            cmbTeam.Properties.ValueMember = "TeamId";

            cmbCode.Properties.DataSource = _employeeService.GetAll();
            cmbCode.Properties.DisplayMember = "EmployeeCode";
            cmbCode.Properties.ValueMember = "EmployeeCode";
        }
        void GetEmployee()
        {
            try
            {

                getEmployeeDetails = _employeeService.GetEmployeeByCode((string)cmbCode.EditValue);
                empId = getEmployeeDetails.EmployeeId;
                txtName.Text = getEmployeeDetails.EmployeeName;
                txtLastName.Text = getEmployeeDetails.EmployeeLastName;
                cmbTeam.EditValue = getEmployeeDetails.EmployeeTeamId;
            }
            catch { }
        }

        private void cmbCode_EditValueChanged(object sender, EventArgs e)
        {
            if ((string)cmbCode.EditValue != (string)cmbCode.Properties.GetKeyValueByDisplayValue(cmbCode.EditValue))
            {

                empId = 0;
            }
            else
            {
                GetEmployee();
            }
        }

        
    }
}