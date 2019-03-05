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
using IsKaiser.Management.WinUI.Reports;
using DevExpress.XtraReports.UI;
using IsKaiser.Management.WinUI.ExceptionHandling;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmNewDebate : DevExpress.XtraEditors.XtraForm
    {
        public frmNewDebate()
        {
            InitializeComponent();
            _debateService = InstanceFactory.GetInstance<IDebateService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _employeeTeamService = InstanceFactory.GetInstance<IEmployeeTeamService>();
        }
        IDebateService _debateService;
        IEmployeeService _employeeService;
        IEmployeeTeamService _employeeTeamService;
        int debId;
        private void tbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                var debateToAdd = new Debate
                {
                    DebateDate = dtpDate.DateTime,
                    DebateDetail = txtDetail.Text,
                    DebateRequested = txtRequested.Text,
                    DebateRequiredEquipment = txtEquipment.Text,
                    DebateSecurityDetail = txtSecurity.Text,
                    EnvoyId = Convert.ToInt32(cmbEmployee.EditValue),
                    TeamId = Convert.ToInt32(cmbTeam.EditValue),
                    CustomerId = frmMain.customerIdx
                };
                _debateService.Add(debateToAdd);
                debId = debateToAdd.DebateId;
                tbtnPrint.Enabled = true;
                tbtnSave.Enabled = false;
                XtraMessageBox.Show("Başarıyla Oluşturuldu.");
            });
        }

        private void frmNewDebate_Load(object sender, EventArgs e)
        {
            if (frmDebateList.debateIdx != 0)
            {
                debId = frmDebateList.debateIdx;
                FillData();
                tbtnSave.Enabled = false;
            }
            else
            {
                tbtnPrint.Enabled = false;
            }
            LoadEmployees();
        }
        void LoadEmployees()
        {
            cmbEmployee.Properties.DataSource = _employeeService.GetAll();
            cmbEmployee.Properties.DisplayMember = "EmployeeName";
            cmbEmployee.Properties.ValueMember = "EmployeeId";

            cmbTeam.Properties.DataSource = _employeeTeamService.GetAll();
            cmbTeam.Properties.DisplayMember = "TeamName";
            cmbTeam.Properties.ValueMember = "TeamId";
        }
       
        void FillData()
        {
            var getDebateDetails = _debateService.Get(frmDebateList.debateIdx);
            cmbEmployee.EditValue = getDebateDetails.EnvoyId;
            cmbTeam.EditValue = getDebateDetails.TeamId;
            dtpDate.EditValue = getDebateDetails.DebateDate;
            txtDetail.Text = getDebateDetails.DebateDetail;
            txtEquipment.Text = getDebateDetails.DebateRequiredEquipment;
            txtRequested.Text = getDebateDetails.DebateRequested;
            txtSecurity.Text = getDebateDetails.DebateSecurityDetail;
        }

        private void tbtnPrint_ItemClick(object sender, TileItemEventArgs e)
        {
            rptStatusDetect rptDurum = new rptStatusDetect(debId);
            rptDurum.ShowPreview();
        }
    }
}