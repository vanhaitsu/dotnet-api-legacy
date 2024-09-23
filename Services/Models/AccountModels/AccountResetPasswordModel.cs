using System.ComponentModel.DataAnnotations;

namespace Services.Models.AccountModels
{
    public class AccountResetPasswordModel
    {
        [Required, EmailAddress] public required string Email { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        public required string Password { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        [Compare("Password")]
        public required string ConfirmPassword { get; set; }

        [Required] public required string Token { get; set; }
    }
}