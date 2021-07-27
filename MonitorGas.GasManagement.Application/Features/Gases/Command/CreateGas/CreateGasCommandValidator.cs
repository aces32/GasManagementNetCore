using FluentValidation;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.CreateGas
{
    public class CreateGasCommandValidator : AbstractValidator<CreateGasCommand>
    {
        private readonly IAsyncRepository<Gas> _gasRepository;

        public CreateGasCommandValidator(IAsyncRepository<Gas> gasRepository)
        {
            _gasRepository = gasRepository;


            RuleFor(p => p.GasVendorName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
    }
}
