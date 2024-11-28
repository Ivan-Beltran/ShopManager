using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class RegisterClientsValidator: AbstractValidator<Clients>
    {
        public RegisterClientsValidator() 
        {
            RuleLevelCascadeMode = CascadeMode.Stop;

            RuleFor(clients => clients.ClientName)
            .NotEmpty().WithMessage("Campo obligatorio");

            RuleFor(clients => clients.ClientLastName)
            .NotEmpty().WithMessage("Campo obligatorio");

            RuleFor(clients => clients.ClientTelephone)
            .NotEmpty().WithMessage("Campo Obligatorio")
              .Matches(@"^\d+$") 
            .WithMessage("El campo debe contener solo números.");

            RuleFor(clients => clients.ClientEmail)
                .NotEmpty().WithMessage("Campo Obligatorio");

            RuleFor(clients => clients.ClientDUI)
                .NotEmpty().WithMessage("Rellenar campo obligatorio, solo numeros")
                 .Matches(@"^\d+$")
            .WithMessage("El campo debe contener solo números.");

        }
    }
}
