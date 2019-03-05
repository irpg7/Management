using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class VehicleValidator:AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(v => v.VehiclePlate).NotEmpty().MaximumLength(8);
            RuleFor(v => v.VehicleType).NotEmpty();
        }
    }
}
