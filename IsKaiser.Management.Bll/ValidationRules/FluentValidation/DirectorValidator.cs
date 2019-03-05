using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class DirectorValidator : AbstractValidator<CustomerDirector>
    {
        public DirectorValidator()
        {
            RuleFor(d => d.DirectorName).NotEmpty()
                .OverridePropertyName("Yönetici Adı").Length(1,50);
            RuleFor(d => d.DirectorTitle).NotEmpty()
                .OverridePropertyName("Yönetici Ünvan").Length(1,50);
            RuleFor(d => d.DirectorGsm).NotEmpty()
                .OverridePropertyName("Yönetici Cep").Length(1,20);
            RuleFor(d => d.DirectorMail).NotEmpty()
                .OverridePropertyName("Yönetici Mail").Length(1,40);
            RuleFor(d => d.DirectorPhone).NotEmpty()
                .OverridePropertyName("Yönetici Telefon").Length(1,20);
        }
    }
}
