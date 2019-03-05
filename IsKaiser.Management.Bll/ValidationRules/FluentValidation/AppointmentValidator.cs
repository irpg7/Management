using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {

        public AppointmentValidator()
        {
            RuleFor(ap => ap.AppointmentDate).NotEmpty()
                .OverridePropertyName("Randevu Tarihi");
            RuleFor(ap => ap.AppointmentDetail).NotEmpty()
                .OverridePropertyName("Randevu Detay")
                .Length(1,600).WithMessage("600 karakterden Fazla olamaz.");
            RuleFor(ap => ap.EnvoyId).NotEmpty()
                .OverridePropertyName("Temsilci");

        }
    }
}
