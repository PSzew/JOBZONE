using JOBZONE.Models;
using Microsoft.EntityFrameworkCore;

namespace JOBZONE
{
    public class DbJobZoneContext : DbContext
    {
        public DbJobZoneContext()
        {

        }
        public DbJobZoneContext(DbContextOptions<DbJobZoneContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<CompanyModel> Company { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        
    }
}
