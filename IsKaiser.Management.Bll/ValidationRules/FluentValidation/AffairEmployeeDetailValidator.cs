using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class AffairEmployeeDetailValidator:AbstractValidator<AffairEmployeeDetail>
    {
        public AffairEmployeeDetailValidator()
        {
           // RuleFor(e => e.AffairId).NotEmpty().OverridePropertyName("İş");
            RuleFor(e => e.BreakTime).NotEmpty().OverridePropertyName("Mola Saati");
            RuleFor(e => e.EmployeeId).NotEmpty().OverridePropertyName("Personel");
            RuleFor(e => e.NetWorkingTime).NotEmpty().OverridePropertyName("Net Çalışma Zamanı");
            RuleFor(e => e.Role).NotEmpty().OverridePropertyName("Personel Rol");
            RuleFor(e => e.WorkingIn).NotEmpty().OverridePropertyName("Çalışma Başlangıç");
            RuleFor(e => e.WorkingOut).NotEmpty().OverridePropertyName("Çalışma Bitiş");
           // RuleFor(e => e.Total).NotEmpty().OverridePropertyName("Toplam");
        }
    }
}
