using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class AppUser : IdentityUser
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
