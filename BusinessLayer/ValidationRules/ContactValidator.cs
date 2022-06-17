using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez !");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adı Boş Geçilemez !");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Konu Adı Boş Geçilemez !");
            RuleFor(x => x.Subject).NotEmpty().MinimumLength(3).WithMessage("En az 3 karakter gir !");
            RuleFor(x => x.UserName).NotEmpty().MinimumLength(3).WithMessage("En az 3 karakter gir !");
            RuleFor(x => x.Subject).NotEmpty().MaximumLength(20).WithMessage("En fazla 50 karakter gir !");
        }
    }
}
