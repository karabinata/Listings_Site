using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Web_Site.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Listings> Listings { get; set; }

        public DbSet<File> Files { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Towns> Towns { get; set; }

        public DbSet<Categories> Categories { get; set; }

    }
}