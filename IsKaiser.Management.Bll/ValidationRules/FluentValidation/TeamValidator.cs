using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class TeamValidator : AbstractValidator<EmployeeTeam>
    {
        public TeamValidator()
        {
            RuleFor(et => et.TeamName).NotEmpty().OverridePropertyName("Takım Adı")
                .Length(1,20);
            // RuleFor(et => et.TeamLeaderId).NotEmpty();
        }
    }
}
