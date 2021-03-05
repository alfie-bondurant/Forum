using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Forum.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Kategoria> Kategorie { get; set; }
        public virtual DbSet<Watek> Watki { get; set; }
        public virtual DbSet<Post> Posty { get; set; }
        public virtual DbSet<Ocena> Oceny { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}