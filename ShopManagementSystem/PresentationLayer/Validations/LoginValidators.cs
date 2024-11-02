using CommonLayer.InputEntities;
using FluentValidation;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class LoginValidators : AbstractValidator<EmployeesInput>
    {
        public LoginValidators()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(employeesInput => employeesInput.User)
                .NotEmpty().WithMessage("Usuario rellenar campo obligatorio");

            RuleFor(employeesInput => employeesInput.Password)
                .NotEmpty().WithMessage("La contraseña no puede estar vacia");
        }
    }
}
