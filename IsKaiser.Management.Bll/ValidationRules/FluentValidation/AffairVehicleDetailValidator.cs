using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class AffairVehicleDetailValidator:AbstractValidator<AffairVehicleDetail>
    {
        public AffairVehicleDetailValidator()
        {
            RuleFor(v => v.VehicleId).NotEmpty().OverridePropertyName("Araç");
            //RuleFor(v => v.AffairId).NotEmpty().OverridePropertyName("İş");
            RuleFor(v => v.Note).MaximumLength(100).OverridePropertyName("Not");

            RuleFor(v => v.WorkingIn).NotEmpty().OverridePropertyName("Araç Çalışma Başlangıç");
            RuleFor(v => v.WorkingOut).NotEmpty().OverridePropertyName("Araç Çalışma Bitiş");
            RuleFor(v => v.WorkingBreak).NotEmpty().OverridePropertyName("Araç Mola");
            RuleFor(v => v.WorkingTotal).NotEmpty().OverridePropertyName("Araç Toplam Çalışma");
        }
    }
}
