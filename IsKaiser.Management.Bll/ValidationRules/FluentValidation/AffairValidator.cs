using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class AffairValidator:AbstractValidator<Affair>
    {
        public AffairValidator()
        {
            RuleFor(a => a.AffairDate).NotEmpty().OverridePropertyName("İş Teslim Tarihi").InclusiveBetween(new DateTime(2018,01,01),new DateTime(2019,01,01));
            RuleFor(a => a.AffairsMade).NotEmpty().OverridePropertyName("Yapılan İş").MaximumLength(100);
            RuleFor(a => a.City).NotEmpty().OverridePropertyName("İl").MaximumLength(30);
            RuleFor(a => a.CustomerId).NotEmpty().OverridePropertyName("Müşteri");

            RuleFor(a => a.Project).NotEmpty().OverridePropertyName("Proje").MaximumLength(50);
            RuleFor(a => a.ProjectNo).NotEmpty().OverridePropertyName("Proje No").MaximumLength(30);
            RuleFor(a => a.VehicleId).NotEmpty().OverridePropertyName("Araç");

            RuleFor(a => a.OrderNo).NotEmpty().OverridePropertyName("Sipariş No");
            RuleFor(a => a.OrderedBy).NotEmpty().OverridePropertyName("Sipariş Veren").MaximumLength(50);

            RuleFor(a => a.EmployeeId).NotEmpty().OverridePropertyName("Temsilci");

        }
    }
}
