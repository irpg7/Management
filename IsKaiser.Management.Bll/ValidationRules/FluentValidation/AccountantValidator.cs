using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class AccountantValidator : AbstractValidator<CustomerAccountant>
    {
        public AccountantValidator()
        {
            RuleFor(a => a.AccountantName).NotEmpty()
                .OverridePropertyName("Muhasebe İsim")
                .Length(1,50);
            RuleFor(a => a.AccountantGsm).NotEmpty()
                .OverridePropertyName("Muhasebe Cep")
                .Length(1,20);
            RuleFor(a => a.AccountantMail).NotEmpty()
                .OverridePropertyName("Muhasebe Mail")
                .Length(1,40);
            RuleFor(a => a.AccountantPhone).NotEmpty()
                .OverridePropertyName("Muhasebe Telefon")
                .Length(1,20);
            RuleFor(a => a.AccountantExpiry).NotEmpty()
                .OverridePropertyName("Muhasebe Vade");
        }
    }
}
