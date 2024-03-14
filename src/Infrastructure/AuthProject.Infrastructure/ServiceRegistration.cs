using AuthProject.Application.Interfaces;
using AuthProject.Domain.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthProject.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<MailSettings>(configuration.GetSection("MailSettings").Value);
            services.AddTransient<IEmailService, EmailService>();
            
        }
    }
}
