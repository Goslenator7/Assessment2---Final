using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Assessment2___Final.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
  
    }

    public class ClickPollDbContext : IdentityDbContext<ApplicationUser>
    {
        public ClickPollDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        // Added
        public DbSet<Cause> Causes { get; set; }

        public static ClickPollDbContext Create()
        {
            return new ClickPollDbContext();
        }
    }
}