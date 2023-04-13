using Entities_.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class BolumValidator:AbstractValidator<Bolumler>
    {
        public BolumValidator() 
        {
            RuleFor(r=>r.Isim).NotEmpty().WithMessage("Bölüm adı boş olamaz");
            RuleFor(r=>r.Isim).MinimumLength(3).WithMessage("Bölüm adı en az 3 karakter olmalıdır");
            RuleFor(r => r.Isim).MaximumLength(25).WithMessage("Bölüm adı en fazla 25 karakter olmalıdır.");
        } 
    }
}
