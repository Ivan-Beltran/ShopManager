using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class EmployeesValidator: AbstractValidator<Employees>
    {
        public EmployeesValidator()
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(employees => employees.Names)
            .NotEmpty().WithMessage("Nombre rellenar campo obligatorio");

            RuleFor(employees => employees.LastNames)
                .NotEmpty().WithMessage("Apellido Rellenar campo obligatorio");

            RuleFor(employees => employees.UserEmployee)
            .NotEmpty().WithMessage("Usuario rellenar campo obligatorio");

            RuleFor(employees => employees.PasswordEmployee)
                .NotEmpty().WithMessage("La contraseña no puede estar vacia");

            RuleFor(employees => employees.DUI)
                .NotEmpty().WithMessage("el DUI no puede estar vacio");

            RuleFor(employees=> employees.Email)
                .NotEmpty().WithMessage("el DUI no puede estar vacio");

            RuleFor(employees => employees.RoleId)
                .NotEmpty().WithMessage("tiene que seleccionar un rol");
            

        }
    }
}
