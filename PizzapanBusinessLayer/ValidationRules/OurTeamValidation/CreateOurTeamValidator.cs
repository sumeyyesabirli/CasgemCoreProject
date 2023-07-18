using FluentValidation;
using PizzapanEntityLayer.Concrete;

namespace PizzapanBusinessLayer.ValidationRules.OurTeamValidation
{
    public class CreateOurTeamValidator:AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Giriniz");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Giriniz");
            
        }
    }
}
