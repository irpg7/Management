using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.DependencyResolvers.Ninject;
using IsKaiser.Management.Entities.Concrete;
using IsKaiser.Management.WinUI.ExceptionHandling;
using IsKaiser.Management.WinUI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class frmInvoice : XtraForm
    {
        IProductService _productService;
        IInvoiceService _invoiceService;
        IInvoiceLineService _invoiceLineService;
        ICustomerService _customerService;
        ISaleInvoiceService _saleInvoiceService;
        public frmInvoice()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _invoiceService = InstanceFactory.GetInstance<IInvoiceService>();
            _saleInvoiceService = InstanceFactory.GetInstance<ISaleInvoiceService>();
            _invoiceLineService = InstanceFactory.GetInstance<IInvoiceLineService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        Dictionary<int, string> invoiceType = new Dictionary<int, string>();
        BindingList<InvoiceLine> invoiceLines;
        private void frmBill_Load(object sender, EventArgs e)
        {
            invoiceType.Add(0, "Satış Faturası");
            invoiceType.Add(1, "Alış Faturası");
            cmbInvoiceType.Properties.Items.AddRange(invoiceType.Values);
            grdcmbTypes.DataSource = invoiceType;
            cmbInvoiceType.SelectedIndex = 0;
            cmbWithholding.SelectedIndex = 0;
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
            ExceptionHandler.HandleException(() =>
            {
                var recToAdd = new Invoice
                {
                    InvoiceType = (short)cmbInvoiceType.SelectedIndex,
                    CustomerId = Convert.ToInt32(cmbCustomers.EditValue),
                    InvoiceDate = dtpDate.DateTime,
                    Number = Convert.ToInt32(txtNo.Text),
                    WaybillNumber = Convert.ToInt32(txtWaybillNo.Text),
                    Serie = txtSerie.Text,
                    ExpiryPeriod = Convert.ToInt16(dtpExpiry.Text),
                    TaxRate = Convert.ToInt16(txtTaxRate.Text),
                    WithholdingRate = Convert.ToInt16(cmbWithholding.EditValue)
                };

                recToAdd.TaxAmount = invoiceLines.Sum(il => il.UnitPrice * il.Quantity) * (recToAdd.TaxRate / (decimal)100.00);
                recToAdd.TotalAmount = invoiceLines.Sum(il => il.UnitPrice * il.Quantity);
                _invoiceService.Add(recToAdd);
                if (cmbInvoiceType.SelectedIndex == 0)
                {
                    var saleInvoice = new SaleInvoice
                    {
                        InvoiceId = recToAdd.InvoiceId,
                        OrderDate = dtpOrderDate.DateTime,
                        OrderedBy = txtOrderedBy.Text,
                        OrderNo = txtOrderNo.Text,
                        RefNumber = txtRefNo.Text,
                        RequestedBy = txtRequest.Text,
                    };
                    _saleInvoiceService.Add(saleInvoice);
                    tbtnPrint.Enabled = true;
                }
                invoiceLines.ToList().ForEach(il => il.InvoiceId = recToAdd.InvoiceId);
                invoiceLines.ToList().ForEach(il => _invoiceLineService.Add(il));
                XtraMessageBox.Show("Kayıt Edildi.");
                invoiceId = recToAdd.InvoiceId;
                tbtnSave.Enabled = false;
                tbtnAttachments.Visible = true;
            });
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
            ExceptionHandler.HandleException(() =>
            {

                invoiceId = Convert.ToInt32(vwBillList.GetFocusedRowCellValue("InvoiceId"));
                var getBill = _invoiceService.Get(invoiceId);
                var getSaleDetails = _saleInvoiceService.Get(invoiceId);
                tabPanel.SelectedPage = tabNewBill;
                tabNewBill.Caption = "Fatura";
                cmbInvoiceType.SelectedIndex = getBill.InvoiceType;
                cmbInvoiceType.Enabled = false;
                if (getBill.InvoiceType==0)
                {
                    tbtnPrint.Enabled = true;
                    txtRefNo.Text = getSaleDetails.RefNumber;
                    txtOrderedBy.Text = getSaleDetails.OrderedBy;
                    txtOrderNo.Text = getSaleDetails.OrderNo;
                    txtRequest.Text = getSaleDetails.RequestedBy;
                    dtpOrderDate.EditValue = getSaleDetails.OrderDate;
                }
                dtpExpiry.Text = getBill.ExpiryPeriod.ToString();
                txtNo.Text = getBill.Number.ToString();
                txtSerie.Text = getBill.Serie;
                txtWaybillNo.Text = getBill.WaybillNumber.ToString();
                txtTaxRate.Text = getBill.TaxRate.ToString();
                cmbWithholding.EditValue = getBill.WithholdingRate;
                cmbCustomers.EditValue = getBill.CustomerId;
                dtpDate.EditValue = getBill.InvoiceDate;
                
                invoiceLines = new BindingList<InvoiceLine>(_invoiceLineService.GetLines(invoiceId));
                grdBill.DataSource = invoiceLines;
                vwBill.OptionsBehavior.ReadOnly = true;
                colProduct.OptionsColumn.AllowFocus = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                colUnitPrice.OptionsColumn.AllowFocus = false;
                tbtnSave.Enabled = false;
                tbtnAttachments.Visible = true;
            });
        }
        void NewBill()
        {
            tbtnPrint.Enabled = false;
            cmbInvoiceType.Enabled = true;
            cmbInvoiceType.SelectedIndex = 0;
            txtNo.ResetText();
            txtRefNo.ResetText();
            txtSerie.ResetText();
            txtTaxRate.Text = "18";
            txtOrderedBy.ResetText();
            txtOrderNo.ResetText();
            txtRequest.ResetText();
            dtpOrderDate.ResetText();
            txtWaybillNo.ResetText();
            cmbWithholding.SelectedIndex = 0;
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
            tbtnAttachments.Visible = false;
        }

        private void tbtnDesign_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraReport newRep = new XtraReport();
            newRep.ShowRibbonDesigner();
        }

        private void tbtnPrint_ItemClick(object sender, TileItemEventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                PrintReport();
            });

        }
        void PrintReport()
        {
            XtraReport billToPrint = new XtraReport();
            decimal calculatedAmount = 0;
            var rec = _invoiceService.Get(invoiceId);
            if (rec.WithholdingRate != 0)
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

        private void cmbInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInvoiceType.SelectedIndex == 0)
            {
                lblOrderDate.Visible = true;
                dtpOrderDate.Visible = true;
                lblOrderedBy.Visible = true;
                txtOrderedBy.Visible = true;
                lblOrderNo.Visible = true;
                txtOrderNo.Visible = true;
                lblRefNo.Visible = true;
                txtRefNo.Visible = true;
                lblRequested.Visible = true;
                txtRequest.Visible = true;
            }
            else
            {
                lblOrderDate.Visible = false;
                dtpOrderDate.Visible = false;
                lblOrderedBy.Visible = false;
                txtOrderedBy.Visible = false;
                lblOrderNo.Visible = false;
                txtOrderNo.Visible = false;
                lblRefNo.Visible = false;
                txtRefNo.Visible = false;
                lblRequested.Visible = false;
                txtRequest.Visible = false;
            }
        }

        private void lookupProduct_DoubleClick(object sender, EventArgs e)
        {
            frmProducts frProduct = new frmProducts();
            frProduct.Show();
        }

        private void CmbCustomers_DoubleClick(object sender, EventArgs e)
        {
            frmNewCustomer frNewCustomer = new frmNewCustomer();
            frNewCustomer.Show();
        }

        private void FrmInvoice_Activated(object sender, EventArgs e)
        {
            lookupProduct.DataSource = _productService.GetList();
            cmbCustomers.Properties.DataSource = _customerService.GetAll();
        }

        private void TbtnPrintList_ItemClick(object sender, TileItemEventArgs e)
        {
            gridBillList.ShowPrintPreview();
        }

        private void VwBillList_PrintInitialize(object sender, DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs e)
        {
            PrintingSystemBase printingSystemBase = e.PrintingSystem as PrintingSystemBase;
            printingSystemBase.PageSettings.Landscape = true;
        }

        private void TbtnAttachments_ItemClick(object sender, TileItemEventArgs e)
        {
            tbtnAttachments.ShowDropDown();
        }

        private void TbtnAdd_ItemClick(object sender, TileItemEventArgs e)
        {
            OpenFileDialog attachmentsDialog = new OpenFileDialog();
            attachmentsDialog.Multiselect = true;
            attachmentsDialog.Filter = "Resim Dosyası|*.jpg;*.png;*.jpeg";
            string pathToSave = Application.StartupPath+"\\Invoices\\"+txtSerie.Text+"-"+txtNo.Text+"\\";
            attachmentsDialog.ShowDialog();
            if (!Directory.Exists(pathToSave))
            {
                Directory.CreateDirectory(pathToSave);
            }
            foreach (var img in attachmentsDialog.FileNames)
            {
                File.Copy(img, pathToSave+Path.GetFileName(img));
            }
            XtraMessageBox.Show("Eklendi!");
        }

        private void TbtnShow_ItemClick(object sender, TileItemEventArgs e)
        {

        }
    }
}