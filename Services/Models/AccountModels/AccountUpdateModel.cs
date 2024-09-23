using System.ComponentModel.DataAnnotations;
using Repositories.Enums;

namespace Services.Models.AccountModels;

public class AccountUpdateModel
{
    [Required] [StringLength(50)] public required string FirstName { get; set; }

    [Required] [StringLength(50)] public required string LastName { get; set; }

    [Required]
    [EnumDataType(typeof(Gender))]
    public Gender Gender { get; set; }

    [Required] public DateOnly DateOfBirth { get; set; }

    public string? Address { get; set; }
    public string? Image { get; set; }

    [Required, Phone] [StringLength(15)] public required string PhoneNumber { get; set; }
}