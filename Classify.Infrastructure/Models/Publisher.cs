using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Classify.Infrastructure.Models
{
    public class Publisher
    {
        public int Id { get; set; }
      
        [Required]
        public string UserName { get; set; } = null!;
        
        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;
        public bool IsAproved { get; set; } = false;
    }
}
