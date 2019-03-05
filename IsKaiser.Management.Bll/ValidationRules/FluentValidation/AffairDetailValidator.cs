using FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.ValidationRules.FluentValidation
{
    public class AffairDetailValidator:AbstractValidator<AffairDetail>
    {
        public AffairDetailValidator()
        {
          //  RuleFor(ad => ad.AffairId).NotEmpty().OverridePropertyName("İş");
            RuleFor(ad => ad.BreakCausedBy).NotEmpty().OverridePropertyName("Kaynaklı Duraklama").MaximumLength(50);
            RuleFor(ad => ad.BreakBeginTime).NotEmpty().OverridePropertyName("Duraklama Başlangıç");
            RuleFor(ad => ad.BreakEndTime).NotEmpty().OverridePropertyName("Duraklama Bitiş");
           // RuleFor(ad => ad.TotalBreakTime).NotEmpty().OverridePropertyName("Toplam Duraklama");
            RuleFor(ad => ad.EquipmentUsed).NotEmpty().OverridePropertyName("Kullanılan Ekipman").MaximumLength(100);
            RuleFor(ad => ad.SignatureDate).NotEmpty().OverridePropertyName("İmza Tarihi");
            RuleFor(ad => ad.EmployeeId).NotEmpty().OverridePropertyName("Temsilci");
            RuleFor(ad => ad.SignaturePath).NotEmpty();
            RuleFor(ad => ad.CustomerAgreement).NotEmpty().OverridePropertyName("Müşteri Onayı").MaximumLength(100);
            RuleFor(ad => ad.CustomerInfo).NotEmpty().OverridePropertyName("Müşteri Ad Soyad").MaximumLength(40);
            RuleFor(ad => ad.CustomerSignaturePath).NotEmpty();
        }
    }
}
