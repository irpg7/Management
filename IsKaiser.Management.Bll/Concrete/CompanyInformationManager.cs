using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class CompanyInformationManager : ICompanyInformationService
    {
        ICompanyInformationDal _companyInformationDal;
        public CompanyInformationManager(ICompanyInformationDal companyInformationDal)
        {
            _companyInformationDal = companyInformationDal;
        }
        [FluentValidationAspect(typeof(CompanyInformationValidator))]
        public void Add(CompanyInformation companyInformation)
        {
            _companyInformationDal.Add(companyInformation);
        }

        public void Delete(CompanyInformation companyInformation)
        {
            _companyInformationDal.Delete(companyInformation);
        }

        public CompanyInformation GetCompany(int id)
        {
            return _companyInformationDal.GetAll().FirstOrDefault();
        }
        [FluentValidationAspect(typeof(CompanyInformationValidator))]
        public void Update(CompanyInformation companyInformation)
        {
            _companyInformationDal.Update(companyInformation);
        }
    }
}
