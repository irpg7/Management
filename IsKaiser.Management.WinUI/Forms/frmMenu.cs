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

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmMenu : XtraForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void navCustomers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMain frMain = new frmMain(frmLogin.UserType);
            frMain.Show();
            Hide();
        }

        private void navBill_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmInvoice frBill = new frmInvoice();
            frBill.Show();
            Hide();
        }

        private void navProducts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmProducts frProducts = new frmProducts();
            frProducts.Show();
            
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void NavlinkEmployee_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNewEmployee frNewEmployee = new frmNewEmployee();
            frNewEmployee.Show();
        }

        private void NavlinkTeam_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNewTeam frNewTeam = new frmNewTeam();
            frNewTeam.Show();
        }

        private void NavlinkUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmNewUser frNewUser = new frmNewUser();
            frNewUser.Show();
        }
    }
}