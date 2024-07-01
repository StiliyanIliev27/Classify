using System.ComponentModel.DataAnnotations;

namespace Classify.Infrastructure.Models
{
    public class Composer
    {
        [Required]
        public int Id { get; set; }
       
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public int YearnBorn { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
