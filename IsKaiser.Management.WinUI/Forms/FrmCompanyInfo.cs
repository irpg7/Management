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
        ICompanyInformationService _companyInformationService;
        ICompanyBankAccountService _companyBankAccountService;
        private void TbtnSave_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void FrmCompanyInfo_Load(object sender, EventArgs e)
        {
            companyInfo = _companyInformationService.GetCompany() ?? _companyInformationService.GetCompany();
        }
    }
}