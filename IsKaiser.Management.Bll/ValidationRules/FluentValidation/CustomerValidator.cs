using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CustomerName).NotEmpty().OverridePropertyName("İsim")
                .Length(1,50);
            RuleFor(p => p.CustomerCode).NotEmpty().OverridePropertyName("Kod")
                .Length(1,8);
            RuleFor(p => p.CustomerTaxNo).NotEmpty().OverridePropertyName("Vergi No.")
                .Length(1,50);
            RuleFor(p => p.CustomerTaxDepartment).NotEmpty()
                .OverridePropertyName("Vergi Dairesi")
                .Length(1,50);
            RuleFor(p => p.CustomerAddress).NotEmpty().OverridePropertyName("Adres")
                .Length(1,150);
           // RuleFor(p => p.CustomerEnvoyId).NotEmpty().OverridePropertyName("Temsilci");
        }

    }
}
