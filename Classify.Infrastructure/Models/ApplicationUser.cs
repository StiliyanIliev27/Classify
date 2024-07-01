using Microsoft.AspNetCore.Identity;

namespace Classify.Infrastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImageUrl { get; set; } = string.Empty;
    }
}
