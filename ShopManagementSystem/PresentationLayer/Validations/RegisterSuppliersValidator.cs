using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class RegisterSuppliersValidator: AbstractValidator<Suppliers>
    {
        public RegisterSuppliersValidator() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(suppliers => suppliers.SupplierName)
                .NotEmpty().WithMessage("Campo obligatorio");

            RuleFor(suppliers => suppliers.SupplierPhone)
            .Matches(@"^\d+(\.\d+)?$")  // Expresión regular para aceptar solo números enteros
            .WithMessage("El campo 'Numero' solo puede contener números.");

            RuleFor(suppliers => suppliers.SupplierEmail)
                .NotEmpty().WithMessage("Campo Obligatorio");

            RuleFor(suppliers => suppliers.SupplierAddres)
                .NotEmpty().WithMessage("Campo Obligatorio");

               
        }
    }
}
