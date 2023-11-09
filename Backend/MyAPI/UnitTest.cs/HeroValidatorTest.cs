using FluentValidation.TestHelper;
using MyAPI;
using Xunit;

namespace UnitTests
{
    public class HeroValidatorTests
    {
        private readonly HeroValidator _validator = new HeroValidator();

        [Fact]
        public void Should_Have_Error_When_Name_Is_Null()
        {

            var model = new Hero { 
                Name = null,
                AlterEgo = null,
                Power = null
            };

            var result = _validator.TestValidate(model);
           
            result.ShouldHaveValidationErrorFor(hero => hero.Name);
           
        }

        [Fact]
        public void Should_Not_Have_Error_When_Name_Is_Specified()
        {
            // Arrange
            var model = new Hero {
                Name = "Batman",
                AlterEgo = "Bruce Wayne",
                Power = "Intelligence"                 
            };

          

            
            var result = _validator.TestValidate(model);
            
            result.ShouldNotHaveValidationErrorFor(hero => hero.Name);
            result.ShouldNotHaveValidationErrorFor(hero => hero.AlterEgo);
        }

       
    }
}
