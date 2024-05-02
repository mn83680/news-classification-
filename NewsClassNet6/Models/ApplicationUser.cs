using Microsoft.AspNetCore.Identity;

namespace NewsClassNet6.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
    }
}