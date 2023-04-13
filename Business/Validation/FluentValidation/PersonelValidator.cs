using Entities_.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class PersonelValidator : AbstractValidator<Personeller>
    {
        public PersonelValidator()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Personel adı boş olamaz");
            RuleFor(x => x.Ad).MinimumLength(3).WithMessage("Personel adı 3 karakterden fazla olmalıdır.");
            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Personel soyadı boş olamaz");
            RuleFor(x => x.Soyad).MinimumLength(3).WithMessage("Personel soyadı 3 karakterden fazla olmalıdır.");
            RuleFor(x => x.Dogum_Tarihi).LessThan(DateTime.Now.AddYears(-18)).WithMessage("18 yaşından küçükler çalışamaz.");
            RuleFor(x => x.Tc_Kimlik_No).MinimumLength(11).MaximumLength(11).WithMessage("11 karakter giriniz");

        }
    }
}
