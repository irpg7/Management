using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class CompanyInformationValidator:AbstractValidator<CompanyInformation>
    {
        public CompanyInformationValidator()
        {

        }
    }
}
