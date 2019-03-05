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

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmAppointmentList : DevExpress.XtraEditors.XtraForm
    {
        public frmAppointmentList()
        {
            InitializeComponent();

            _appointmentService = InstanceFactory.GetInstance<IAppointmentService>();
        }
        IAppointmentService _appointmentService;
        public static int appointmentIdx;
        private void frmAppointmentList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _appointmentService.GetAllByCustomer(frmMain.customerIdx);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            appointmentIdx = Convert.ToInt32(gridView1.GetFocusedRowCellValue("AppointmentId"));
            frmNewAppointment frNewAppointment = new frmNewAppointment();
            frNewAppointment.Show();
        }
    }
}