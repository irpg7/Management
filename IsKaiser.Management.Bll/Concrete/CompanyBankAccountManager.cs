using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class CompanyBankAccountManager : ICompanyBankAccountService
    {
        ICompanyBankAccountDal _companyBankAccountDal;
        public CompanyBankAccountManager(ICompanyBankAccountDal companyBankAccountDal)
        {
            _companyBankAccountDal = companyBankAccountDal;
        }
        [FluentValidationAspect(typeof(CompanyBankAccountValidator))]
        public void Add(CompanyBankAccount companyBankAccount)
        {
            _companyBankAccountDal.Add(companyBankAccount);
        }

        public void Delete(CompanyBankAccount companyBankAccount)
        {
            _companyBankAccountDal.Delete(companyBankAccount);
        }

        public CompanyBankAccount GetBankAccount(int companyId)
        {
            return _companyBankAccountDal.Get(cb => cb.CompanyId == companyId);
        }
        [FluentValidationAspect(typeof(CompanyBankAccountValidator))]
        public void Update(CompanyBankAccount companyBankAccount)
        {
            _companyBankAccountDal.Update(companyBankAccount);
        }
    }
}
