using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty().OverridePropertyName("Kullanıcı Adı")
                .Length(1,10);
            RuleFor(u => u.UserPw).NotEmpty().OverridePropertyName("Şifre")
                .Length(1,6);
            RuleFor(u => u.UserType).NotEmpty().OverridePropertyName("Kullanıcı Tipi");
            //RuleFor(u => u.EmployeeId).NotEmpty().WithMessage("Boş Olmamalıdır").OverridePropertyName("Kime Ait");

        }
    }
}
