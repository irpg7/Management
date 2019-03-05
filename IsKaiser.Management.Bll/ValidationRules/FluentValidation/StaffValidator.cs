using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class StaffValidator : AbstractValidator<CustomerPurchasingStaff>
    {
        public StaffValidator()
        {
            RuleFor(s => s.PurchaseStaffName).NotEmpty()
                .OverridePropertyName("Satın Alma Yetkili").Length(1,50);
            RuleFor(s => s.PurchaseStaffGsm).NotEmpty()
                .OverridePropertyName("Satın Alma Cep").Length(1,20);
            RuleFor(s => s.PurchaseStaffMail).NotEmpty()
                .OverridePropertyName("Satın Alma Mail").Length(1,40);
            RuleFor(s => s.PurchaseStaffPhone).NotEmpty()
                .OverridePropertyName("Satın Alma Telefon").Length(1,20);

        }
    }
}
