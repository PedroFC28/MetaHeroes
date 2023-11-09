using FluentValidation;

namespace MyAPI
{
    public class HeroValidator : AbstractValidator<Hero>
    {
        public HeroValidator()
        {
            RuleFor(hero => hero.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");

            RuleFor(hero => hero.AlterEgo)
                .NotEmpty().WithMessage("Alter Ego is required.")
                .Length(2, 50).WithMessage("Alter Ego must be between 2 and 50 characters.");

        }
    }
}
