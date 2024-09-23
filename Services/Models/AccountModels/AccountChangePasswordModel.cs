using System.ComponentModel.DataAnnotations;

namespace Services.Models.AccountModels
{
    public class AccountChangePasswordModel
    {
        [Required]
        [StringLength(128, MinimumLength = 8)]
        public required string OldPassword { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        public required string NewPassword { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        [Compare("NewPassword")]
        public required string ConfirmPassword { get; set; }
    }
}