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
    public partial class frmNewAppointment : DevExpress.XtraEditors.XtraForm
    {
        public frmNewAppointment()
        {
            InitializeComponent();
            _appointmentService = InstanceFactory.GetInstance<IAppointmentService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }
        IAppointmentService _appointmentService;
        IEmployeeService _employeeService;
        private void tbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {
            ExceptionHandler.HandleException(() => { 
                var appointmentToAdd = new Appointment
                {
                    EnvoyId = Convert.ToInt32(cmbEnvoy.EditValue),
                    AppointmentDate = dtpAppoinmentDate.DateTime,
                    AppointmentDetail = txtAppointmentDetail.Text,
                    CustomerId = frmMain.customerIdx
                };
                _appointmentService.Add(appointmentToAdd);
                tbtnSave.Enabled = false;
                XtraMessageBox.Show("Başarıyla oluşturuldu.");
            });

        }

        
        private void frmNewAppointment_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            if (frmAppointmentList.appointmentIdx != 0)
            {
                FillData();
                tbtnSave.Enabled = false;
            }

        }
        void FillData()
        {
            var getAppointmentDetails = _appointmentService.Get(frmAppointmentList.appointmentIdx);
            txtAppointmentDetail.Text = getAppointmentDetails.AppointmentDetail;
            dtpAppoinmentDate.EditValue = getAppointmentDetails.AppointmentDate;
            cmbEnvoy.EditValue = getAppointmentDetails.EnvoyId;
        }
        void LoadEmployees()
        {
            cmbEnvoy.Properties.DataSource = _employeeService.GetAll();
            cmbEnvoy.Properties.DisplayMember = "EmployeeName";
            cmbEnvoy.Properties.ValueMember = "EmployeeId";
        }
    }
}