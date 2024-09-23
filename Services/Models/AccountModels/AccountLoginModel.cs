using System.ComponentModel.DataAnnotations;

namespace Services.Models.AccountModels
{
    public class AccountLoginModel
    {
        [Required, EmailAddress]
        [StringLength(256)]
        public required string Email { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        public required string Password { get; set; }
    }
}