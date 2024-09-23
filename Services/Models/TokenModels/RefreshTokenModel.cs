using System.ComponentModel.DataAnnotations;

namespace Services.Models.TokenModels
{
    public class RefreshTokenModel
    {
        [Required]
        public required string AccessToken { get; set; }

        public string? RefreshToken { get; set; }
    }
}