using CrudEmploye.DTOs;
using FluentValidation;

namespace CrudEmploye.ValidatorDTOs
{
    public class ValidatorEmployee : AbstractValidator<EmployeeDTO>
    {
        public ValidatorEmployee()
        {
            
        }
    }
}
