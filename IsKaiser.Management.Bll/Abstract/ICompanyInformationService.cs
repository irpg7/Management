using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICompanyInformationService
    {
        void Add(CompanyInformation companyInformation);
        void Update(CompanyInformation companyInformation);
        void Delete(CompanyInformation companyInformation);
        CompanyInformation GetCompany();
    }
}
