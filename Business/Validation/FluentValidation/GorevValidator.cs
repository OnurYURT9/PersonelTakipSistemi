using Entities_.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class GorevValidator :AbstractValidator<Gorevler>
    {
        public GorevValidator()
        {
            RuleFor(r => r.Ad).NotEmpty().WithMessage("Görev adı boş olamaz");
            RuleFor(r => r.Ad).MinimumLength(3).WithMessage("Görev adı en az 3 karakter olmalıdır");
            RuleFor(r => r.Ad).MaximumLength(25).WithMessage("Görev adı en fazla 25 karakter olmalıdır.");
        }
    }
}
