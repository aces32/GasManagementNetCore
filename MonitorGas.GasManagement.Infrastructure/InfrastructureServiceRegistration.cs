using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MonitorGas.GasManagement.Application.Contracts.Infrastructure;
using MonitorGas.GasManagement.Application.Model.Mail;
using MonitorGas.GasManagement.Infrastructure.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorGas.GasManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
