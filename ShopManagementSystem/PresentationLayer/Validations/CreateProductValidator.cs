using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class CreateProductValidator: AbstractValidator<Products>
    {
        public CreateProductValidator() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(products => products.ProductTypeId)
          .NotEmpty().WithMessage("Debe seleccionear un tipo")
          .NotEqual(0).WithMessage("Debe seleccionar un tipo");

            RuleFor(products => products.ProductBrand)
            .NotEmpty().WithMessage("Debe definir una marca");

            RuleFor(products => products.ProductModel)
          .NotEmpty().WithMessage("Debe escribir el modelo");

            RuleFor(products => products.ProductVersion)
          .NotEmpty().WithMessage("Debe especifir la version");

            RuleFor(products => products.ProductColor)
          .NotEmpty().WithMessage("Debe escribir el color");

            RuleFor(products => products.ProductPrice) 
            .NotEmpty().WithMessage("Debe ingresar un precio valido")
           .GreaterThan(0).WithMessage("La cantidad debe ser mayor que cero.");
        }
    }
}
