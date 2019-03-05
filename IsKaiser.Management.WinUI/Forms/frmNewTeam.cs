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
    public partial class frmNewTeam : DevExpress.XtraEditors.XtraForm
    {
        public frmNewTeam()
        {
            InitializeComponent();
            _employeeTeamService = InstanceFactory.GetInstance<IEmployeeTeamService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        IEmployeeTeamService _employeeTeamService;
        IEmployeeService _employeeService;
        int teamId;
        private void btnSave_Click(object sender, EventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                if (teamId == 0)
                {
                    var teamToAdd = new EmployeeTeam
                    {
                        TeamName = cmbTeamName.Text,
                        TeamLeaderId = (int)cmbTeamLeader.EditValue
                    };
                    _employeeTeamService.Add(teamToAdd);
                    XtraMessageBox.Show("Kaydedildi.");
                }
                else
                {
                    var teamToUpdate = new EmployeeTeam
                    {
                        TeamId = teamId,
                        TeamName = cmbTeamName.Text,
                        TeamLeaderId = (int)cmbTeamLeader.EditValue
                    };
                    _employeeTeamService.Update(teamToUpdate);
                    XtraMessageBox.Show("Güncellendi.");
                }
                LoadLookups();

            });
        }


        private void frmNewTeam_Load(object sender, EventArgs e)
        {
            LoadLookups();
        }
        void LoadLookups()
        {
            cmbTeamLeader.Properties.DataSource = _employeeService.GetAll();
            cmbTeamLeader.Properties.DisplayMember = "EmployeeName";
            cmbTeamLeader.Properties.ValueMember = "EmployeeId";

            cmbTeamName.Properties.DataSource = _employeeTeamService.GetAll();
            cmbTeamName.Properties.DisplayMember = "TeamName";
            cmbTeamName.Properties.ValueMember = "TeamName";
        }

        private void cmbTeamName_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbTeamName.EditValue != cmbTeamName.Properties.GetKeyValueByDisplayValue(cmbTeamName.EditValue))
            {
                teamId = 0;
            }
            else
            {
                teamId = (int)cmbTeamName.GetColumnValue("TeamId");
            }
        }
    }
}