using System.ComponentModel.DataAnnotations;

namespace Services.Models.CommonModels
{
    public class EmailModel
    {
        [Required, EmailAddress]
        [StringLength(256)]
        public required string Email { get; set; }
    }
}