using AuthProject.Application.Dtos.Accounts;
using AuthProject.Application.Wrappers;

namespace AuthProject.Application.Interfaces.Identity;

public interface IAccountService
{
    Task<ApiResponse<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
    Task<ApiResponse<string>> RegisterAsync(RegisterRequest request, string origin);
    Task<ApiResponse<string>> ConfirmEmailAsync(string userId, string code);
    Task ForgotPassword(ForgotPasswordRequest model, string origin);
    Task<ApiResponse<string>> ResetPassword(ResetPasswordRequest model);
}
