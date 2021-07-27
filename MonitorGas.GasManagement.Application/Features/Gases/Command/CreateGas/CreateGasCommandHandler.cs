using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using MonitorGas.GasManagement.Application.Contracts.Infrastructure;
using MonitorGas.GasManagement.Application.Contracts.Persistence;
using MonitorGas.GasManagement.Application.Exceptions;
using MonitorGas.GasManagement.Application.Model.Mail;
using MonitorGas.GasManagement.Application.Persistence;
using MonitorGas.GasManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Application.Features.Gases.Command.CreateGas
{
    public class CreateGasCommandHandler : IRequestHandler<CreateGasCommand, Guid>
    {
        private readonly IAsyncRepository<Gas> _gasRepository;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateGasCommandHandler> _logger;
        public CreateGasCommandHandler(IMapper mapper, IAsyncRepository<Gas> gasRepository, IEmailService emailService,
                ILogger<CreateGasCommandHandler> logger)
        {
            _mapper = mapper;
            _emailService = emailService;
            _gasRepository = gasRepository;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateGasCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateGasCommandValidator(_gasRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            var gas = _mapper.Map<Gas>(request);

            gas = await _gasRepository.AddAsync(gas);

            //Sending email notification to admin address
            var email = new Email() { To = "buarisulaimon@gmail.com", Body = $"A new gas was created: {request}", Subject = "A new gas was created" };

            try
            {
                await _emailService.SendEmail(email);
            }
            catch (Exception ex)
            {
                //this shouldn't stop the API from doing else so this can be logged
                _logger.LogError($"Mailing about event {gas.GasID} failed due to an error with the mail service: {ex.Message}");
            }

            return gas.GasID;
        }
    }
}
