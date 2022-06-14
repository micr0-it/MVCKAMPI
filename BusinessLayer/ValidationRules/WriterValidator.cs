using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Boş Geçilemez !");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı Boş Geçilemez !");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmı Boş Geçilemez !");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan Kısmı Boş Geçilemez !");
            RuleFor(x => x.WriterSurname).NotEmpty().MinimumLength(3).WithMessage("En az 2 karakter gir !");
            RuleFor(x => x.WriterSurname).NotEmpty().MaximumLength(20).WithMessage("En fazla 50 karakter gir !");
        }
    }
}
