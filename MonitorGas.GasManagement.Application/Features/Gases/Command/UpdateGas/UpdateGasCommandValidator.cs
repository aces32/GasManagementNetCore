using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.UpdateGas
{
    public class UpdateGasCommandValidator : AbstractValidator<UpdateGasCommand>
    {
        public UpdateGasCommandValidator()
        {
            RuleFor(p => p.GasVendorName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
    }
}
