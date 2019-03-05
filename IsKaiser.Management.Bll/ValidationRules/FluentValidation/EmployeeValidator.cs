using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.EmployeeCode).NotEmpty()
                .OverridePropertyName("Çalışan Kod").Length(1,6);
            RuleFor(e => e.EmployeeName).NotEmpty()
                .OverridePropertyName("Çalışan İsim").Length(1,20);

            RuleFor(e => e.EmployeeLastName).NotEmpty()
                .OverridePropertyName("Çalışan Soyad").Length(1,20);


        }
    }
}
