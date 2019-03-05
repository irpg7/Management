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
            Hide();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}