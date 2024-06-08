using JOBZONE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JOBZONE
{
    public class DbJobZoneContext : IdentityDbContext
    {
        public DbJobZoneContext()
        {

        }
        public DbJobZoneContext(DbContextOptions<DbJobZoneContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<JobOfferModel> JobOffer { get; set; }
        public DbSet<OfferModel> Offers { get; set; }
        public DbSet<EducationModel> Education { get; set; }
        public DbSet<CertificateModel> Certificates { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserModel>()
            .HasMany(u => u.Applied)
            .WithOne(p => p.UserModel)
            .HasForeignKey(p => p.UserId);
        }
        
        public DbSet<JOBZONE.Models.LinksModel>? LinksModel { get; set; }

    }
}
