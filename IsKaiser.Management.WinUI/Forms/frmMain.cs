using DevExpress.XtraEditors;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.WinUI.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmMain : XtraForm
    {
        public frmMain(int userType)
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
           
            _excelImporter = new ExcelImporter(); //!.Net Framework Bağımlılığından dolayı böyle çağırıldı.
            if (userType == 2)
            {
                tbGroupAdmin.Visible = false;
            }
        }
        ICustomerService _customerService;
       
        IExcelImporter _excelImporter;
        public static int customerIdx;
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCustomers();

        }

        private void LoadCustomers()
        {
            grdCustomers.DataSource = _customerService.GetAll();
        }

        private void tbtnNewCustomer_ItemClick(object sender, TileItemEventArgs e)
        {
            customerIdx = 0;
            frmNewCustomer frNewCustomer = new frmNewCustomer();
            frNewCustomer.Show();
        }

        private void tbtnRefresh_ItemClick(object sender, TileItemEventArgs e)
        {
            LoadCustomers();
        }

        private void tbtnExport_ItemClick(object sender, TileItemEventArgs e)
        {
            SaveFileDialog _saveGridToExcel = new SaveFileDialog();
            _saveGridToExcel.Filter = "*|.xlsx";
            _saveGridToExcel.ShowDialog();
            string _pathToSave = _saveGridToExcel.FileName;

            if (!String.IsNullOrEmpty(_pathToSave))
            {
                vwCustomers.ExportToXlsx(_pathToSave);
            }
        }

        private void tbtnImport_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    _excelImporter.ImportXl(ofd.FileName, _customerService);
                    MessageBox.Show("İşlem Tamamlandı.");
                }
                
            }
            catch (Exception exception) { MessageBox.Show(exception.Message); }
        }

        private void tbtnNewEmployee_ItemClick(object sender, TileItemEventArgs e)
        {
            frmNewEmployee frNewEmployee = new frmNewEmployee();
            frNewEmployee.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenu frMenu = new frmMenu();
            frMenu.Show();
        }

        private void tbtnNewTeam_ItemClick(object sender, TileItemEventArgs e)
        {
            frmNewTeam frNewTeam = new frmNewTeam();
            frNewTeam.Show();
        }

        private void tbtnNewUser_ItemClick(object sender, TileItemEventArgs e)
        {
            frmNewUser frNewUser = new frmNewUser();
            frNewUser.Show();
        }

        private void vwCustomers_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            customerIdx = Convert.ToInt32(vwCustomers.GetFocusedRowCellValue("CustomerId"));
            frmNewCustomer frNewCustomer = new frmNewCustomer();
            frNewCustomer.Show();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            LoadCustomers();
        }
    }
}