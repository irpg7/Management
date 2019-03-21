using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class CompanyBankAccountValidator:AbstractValidator<CompanyBankAccount>
    {
        public CompanyBankAccountValidator()
        {
            RuleFor(cb => cb.BankName).NotEmpty().OverridePropertyName("Banka Adı");
            RuleFor(cb => cb.BranchOffice).NotEmpty().OverridePropertyName("Şube");
            RuleFor(cb => cb.LiraIban).NotEmpty().OverridePropertyName("TL IBAN").MaximumLength(50);
            RuleFor(cb => cb.SwiftCode).NotEmpty().OverridePropertyName("Swift Kodu").MaximumLength(11);
            RuleFor(cb => cb.DollarIban).NotEmpty().OverridePropertyName("Dolar IBAN").MaximumLength(50);
            RuleFor(cb => cb.EuroIban).NotEmpty().OverridePropertyName("Euro IBAN").MaximumLength(50);
        }
    }
}
