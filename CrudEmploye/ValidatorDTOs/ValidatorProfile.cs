using CrudEmploye.DTOs;
using FluentValidation;

namespace CrudEmploye.ValidatorDTOs
{
    public class ValidatorProfile : AbstractValidator<ProfileDTO>
    {
        public ValidatorProfile()
        {
            RuleFor(profile => profile.Name)
                .NotEmpty()
                .WithMessage("El campo {PropertyName} es requerido")
                .Length(3, 50)
                .WithMessage("El campo debe tener entre 3 y 50 caracteres")
                .Matches("^[a-zA-Z ]*$")
                .WithMessage("El campo no debe contener numeros o caracteres especiales");
        }
    }
}
