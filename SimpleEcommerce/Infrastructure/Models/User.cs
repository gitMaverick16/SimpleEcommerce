using Microsoft.AspNetCore.Identity;

namespace SimpleEcommerce.Infrastructure.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
