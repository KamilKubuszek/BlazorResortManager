using BlazorResortManager1.user;
using Microsoft.AspNetCore.Identity;

namespace BlazorResortManager1.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Permit> permits { get; set; } = new List<Permit>();
    }

}
