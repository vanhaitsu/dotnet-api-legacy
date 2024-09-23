using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Services.Models.AccountModels
{
    public class AccountRegisterModel
    {
        [Required] [StringLength(50)] public required string FirstName { get; set; }

        [Required] [StringLength(50)] public required string LastName { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required] public DateOnly DateOfBirth { get; set; }

        public string? Address { get; set; }

        [Required, Phone] [StringLength(15)] public required string PhoneNumber { get; set; }

        [Required, EmailAddress]
        [StringLength(256)]
        public required string Email { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        public required string Password { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 8)]
        [Compare("Password")]
        public required string ConfirmPassword { get; set; }

        [EnumDataType(typeof(Role))] public Role? Role { get; set; }
    }
}