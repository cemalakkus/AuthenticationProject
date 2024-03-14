using System.ComponentModel.DataAnnotations;

namespace AuthProject.Application.Dtos.Accounts;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
