using CommonLayer.Entities;
using FluentValidation;
using PresentationLayer.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class LoginValidators : AbstractValidator<Employees>
    {
        public LoginValidators()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(employees => employees.User)
                .NotEmpty().WithMessage("Usuario rellenar campo obligatorio");

            RuleFor(employees => employees.Password)
                .NotEmpty().WithMessage("La contraseña no puede estar vacia");
        }
    }
}
