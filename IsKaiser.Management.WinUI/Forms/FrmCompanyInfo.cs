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
using IsKaiser.Management.WinUI.ExceptionHandling;

namespace IsKaiser.Management.WinUI.Forms
{
    public partial class FrmCompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        public FrmCompanyInfo()
        {
            InitializeComponent();
            _companyInformationService = InstanceFactory.GetInstance<ICompanyInformationService>();
            _companyBankAccountService = InstanceFactory.GetInstance<ICompanyBankAccountService>();
        }
        CompanyInformation companyInfo;
        CompanyBankAccount companyBankAccount;
        ICompanyInformationService _companyInformationService;
        ICompanyBankAccountService _companyBankAccountService;
        private void TbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {
            ExceptionHandler.HandleException(() =>
            {
                var info = new CompanyInformation
                {
                    Name = txtCompanyName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    TaxDepartment = txtTaxDepartment.Text,
                    TaxNo = txtTaxNo.Text
                };
                var account = new CompanyBankAccount
                {
                    BankName = txtBankName.Text,
                    BranchOffice = txtBranchOffice.Text,
                    DollarIban = txtDolarIban.Text,
                    EuroIban = txtEuroIban.Text,
                    LiraIban = txtTLIban.Text,
                    SwiftCode = txtSwiftCode.Text
                };
                if (companyInfo == null)
                {
                    _companyInformationService.Add(info);
                    account.CompanyId = info.Id;
                    _companyBankAccountService.Add(account);
                    XtraMessageBox.Show("Başarıyla Kayıt Edildi.");
                }
                else
                {
                    info.Id = companyInfo.Id;
                    account.AccountId = companyBankAccount.AccountId;
                    account.CompanyId = companyInfo.Id;
                    _companyInformationService.Update(info);
                    _companyBankAccountService.Update(account);
                    XtraMessageBox.Show("Başarıyla Güncellendi.");
                }
            });
        }

        private void FrmCompanyInfo_Load(object sender, EventArgs e)
        {
            companyInfo = _companyInformationService.GetCompany();
            if (companyInfo!=null)
            {
                companyBankAccount = _companyBankAccountService.GetBankAccount(companyInfo.Id);
                txtAddress.Text = companyInfo.Address;
                txtBankName.Text = companyBankAccount.BankName;
                txtBranchOffice.Text = companyBankAccount.BranchOffice;
                txtCompanyName.Text = companyInfo.Name;
                txtDolarIban.Text = companyBankAccount.DollarIban;
                txtEuroIban.Text = companyBankAccount.EuroIban;
                txtPhone.Text = companyInfo.Phone;
                txtTaxDepartment.Text = companyInfo.TaxDepartment;
                txtTaxNo.Text = companyInfo.TaxNo;
                txtTLIban.Text = companyBankAccount.LiraIban;
                txtSwiftCode.Text = companyBankAccount.SwiftCode;
            }
        }

        
    }
}