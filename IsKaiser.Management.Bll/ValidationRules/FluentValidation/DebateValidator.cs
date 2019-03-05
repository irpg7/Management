using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class DebateValidator : AbstractValidator<Debate>
    {
        public DebateValidator()
        {
            RuleFor(d => d.DebateDate).NotEmpty()
                .OverridePropertyName("Görüşme Tarihi");
            RuleFor(d => d.DebateDetail).NotEmpty()
                .OverridePropertyName("Görüşme Detayı").Length(1,600);
            RuleFor(d => d.DebateRequested).NotEmpty()
                .OverridePropertyName("Talep Edilen").Length(1,600);
            RuleFor(d => d.DebateRequiredEquipment).NotEmpty()
                .OverridePropertyName("Gerekli Ekipman").Length(1,600);
            RuleFor(d => d.DebateSecurityDetail).NotEmpty()
                .OverridePropertyName("Güvenlik Tedbirleri").Length(1,600);
            RuleFor(d => d.EnvoyId).NotEmpty()
                .OverridePropertyName("Temsilci");
            RuleFor(d => d.TeamId).NotEmpty()
                .OverridePropertyName("Ekip");
        }
    }
}
