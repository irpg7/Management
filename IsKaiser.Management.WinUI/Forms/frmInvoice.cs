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
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using DevExpress.XtraReports.UI;
using IsKaiser.Management.WinUI.Utilities;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmInvoice : XtraForm
    {
        IProductService _productService;
        IInvoiceService _invoiceService;
        IInvoiceLineService _invoiceLineService;
        ICustomerService _customerService;
        public frmInvoice()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _invoiceService = InstanceFactory.GetInstance<IInvoiceService>();
            _invoiceLineService = InstanceFactory.GetInstance<IInvoiceLineService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        BindingList<InvoiceLine> invoiceLines;
        private void frmBill_Load(object sender, EventArgs e)
        {
            lookupProduct.DataSource = _productService.GetList();
            cmbCustomers.Properties.DataSource = _customerService.GetAll();
            NewBill();
            FillBillList();
        }
        
        private void frmBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frMenu = new frmMenu();
            frMenu.Show();
        }
        void FillBillList()
        {
            gridBillList.DataSource = _invoiceService.GetList();
            lookupCustomer.DataSource = _customerService.GetAll();
        }
        private void tbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {
            var recToAdd = new Invoice
            {
                CustomerId = Convert.ToInt32(cmbCustomers.EditValue),
                ExpiryDate = dtpExpiry.DateTime,
                InvoiceDate = dtpDate.DateTime,
                Number = Convert.ToInt32(txtNo.Text),
                RefNumber = txtRefNo.Text,
                Serie = txtSerie.Text,
                TaxRate = Convert.ToInt16(txtTaxRate.Text),
                WithholdingRate = Convert.ToInt16(cmbWithholding.EditValue)
            };
            recToAdd.TaxAmount = invoiceLines.Sum(il => il.UnitPrice*il.Quantity)*(recToAdd.TaxRate/(decimal)100.00);
            recToAdd.TotalAmount = invoiceLines.Sum(il => il.UnitPrice*il.Quantity);
            _invoiceService.Add(recToAdd);
            invoiceLines.ToList().ForEach(il => il.InvoiceId = recToAdd.InvoiceId);
            invoiceLines.ToList().ForEach(il => _invoiceLineService.Add(il));

        }

        private void tabPanel_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (tabPanel.SelectedPage == tabBillList)
            {
                FillBillList();
                tabNewBill.Caption = "Yeni Fatura";
                NewBill();
            }
        }
        int invoiceId;
        private void tbtnGoTo_ItemClick(object sender, TileItemEventArgs e)
        {
            invoiceId = Convert.ToInt32(vwBillList.GetFocusedRowCellValue("InvoiceId"));
            var getBill = _invoiceService.Get(invoiceId);
            tabPanel.SelectedPage = tabNewBill;
            tabNewBill.Caption = "Fatura";
            txtNo.Text = getBill.Number.ToString();
            txtRefNo.Text = getBill.RefNumber;
            txtSerie.Text = getBill.Serie;
            txtTaxRate.Text = getBill.TaxRate.ToString();
            cmbWithholding.EditValue = getBill.WithholdingRate;
            cmbCustomers.EditValue = getBill.CustomerId;
            dtpDate.EditValue = getBill.InvoiceDate;
            dtpExpiry.EditValue = getBill.ExpiryDate;
            invoiceLines= new BindingList<InvoiceLine>(_invoiceLineService.GetLines(invoiceId));
            grdBill.DataSource = invoiceLines;
            vwBill.OptionsBehavior.ReadOnly = true;
            colProduct.OptionsColumn.AllowFocus = false;
            colQuantity.OptionsColumn.AllowFocus = false;
            colUnitPrice.OptionsColumn.AllowFocus = false;
            tbtnSave.Enabled = false;
        }
        void NewBill()
        {
            txtNo.ResetText();
            txtRefNo.ResetText();
            txtSerie.ResetText();
            txtTaxRate.ResetText();
            cmbWithholding.ResetText();
            cmbCustomers.EditValue = 0;
            dtpDate.ResetText();
            dtpExpiry.ResetText();
            invoiceLines = new BindingList<InvoiceLine>();
            invoiceLines.AllowNew = true;
            grdBill.DataSource = invoiceLines;
            vwBill.OptionsBehavior.ReadOnly = false;
            colProduct.OptionsColumn.AllowFocus = true;
            colQuantity.OptionsColumn.AllowFocus = true;
            colUnitPrice.OptionsColumn.AllowFocus = true;
            tbtnSave.Enabled = true;
        }

        private void tbtnDesign_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraReport newRep = new XtraReport();
            newRep.ShowRibbonDesigner();
        }

        private void tbtnPrint_ItemClick(object sender, TileItemEventArgs e)
        {
            PrintReport();
        }
        void PrintReport()
        {
            XtraReport billToPrint = new XtraReport();
            decimal calculatedAmount=0;
            var rec = _invoiceService.Get(invoiceId);
            if (rec.WithholdingRate!=0)
            {
                billToPrint.LoadLayout(Application.StartupPath + "/Reports/TevkifFatura.repx");
                calculatedAmount = rec.TotalAmount + (rec.TaxAmount / 10) * (10 - rec.WithholdingRate);
            }
            else
            {
                billToPrint.LoadLayout(Application.StartupPath + "/Reports/KdvFatura.repx");
                calculatedAmount = rec.TotalAmount + rec.TaxAmount;
            }
            billToPrint.Parameters["Number"].Value = invoiceId;
            billToPrint.Parameters["WithText"].Value = AmountToText.ConvertToText(calculatedAmount);
            billToPrint.ShowRibbonPreview();
        }
    }
}