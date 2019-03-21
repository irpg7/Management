using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface ICompanyBankAccountService
    {
        void Add(CompanyBankAccount companyBankAccount);
        void Update(CompanyBankAccount companyBankAccount);
        void Delete(CompanyBankAccount companyBankAccount);
        CompanyBankAccount GetBankAccount(int companyId);
    }
}
