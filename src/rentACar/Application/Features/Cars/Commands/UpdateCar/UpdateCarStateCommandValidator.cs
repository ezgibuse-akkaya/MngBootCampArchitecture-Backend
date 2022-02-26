using Domain.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Commands.UpdateCar
{
    public class UpdateCarStateCommandValidator : AbstractValidator<UpdateCarStateCommand>
    {
        public UpdateCarStateCommandValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.CarState).IsInEnum()
                .WithMessage("Araç durumu hatalı. Böyle bir araç durumu yok");
        }
    }
}
