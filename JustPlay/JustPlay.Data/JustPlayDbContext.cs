namespace JustPlay.Data
{
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    public class JustPlayDbContext : IdentityDbContext<User>, IJustPlayDbContext
    {
        public JustPlayDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Sound> Sounds { get; set; }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        public static JustPlayDbContext Create()
        {
            return new JustPlayDbContext();
        }
    }
}
