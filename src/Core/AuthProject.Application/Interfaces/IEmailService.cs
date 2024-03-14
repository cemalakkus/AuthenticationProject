using AuthProject.Application.Dtos.Email;

namespace AuthProject.Application.Interfaces;

public interface IEmailService
{
    Task SendAsync(EmailRequest request);
}
