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
    public partial class frmDebateList : DevExpress.XtraEditors.XtraForm
    {
        public frmDebateList()
        {
            InitializeComponent();
            _debateService = InstanceFactory.GetInstance<IDebateService>();
        }
        IDebateService _debateService;
        public static int debateIdx;
        private void frmDebateList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _debateService.GetAllByCustomer(frmMain.customerIdx);
            gridView1.BestFitColumns();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            debateIdx = Convert.ToInt32(gridView1.GetFocusedRowCellValue("DebateId"));
            frmNewDebate frNewDebate = new frmNewDebate();
            frNewDebate.Show();
        }
    }
}