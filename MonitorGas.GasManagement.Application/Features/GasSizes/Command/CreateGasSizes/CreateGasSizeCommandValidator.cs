using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.GasSizes.Command.CreateGasSizes
{
    public class CreateGasSizeCommandValidator : AbstractValidator<CreateGasSizeCommand>
    {
        public CreateGasSizeCommandValidator()
        {
            RuleFor(p => p.SizeInKg)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0);

        }
    }
}
