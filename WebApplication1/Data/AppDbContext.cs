using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

using WebApplication1.Models.Users;

namespace WebApplication1.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {


        }


        public DbSet<ApplicationUser> ApplicationUser { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     


            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Identity");
            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable(name: "User");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });


        


 /*       modelBuilder.Entity<ArmateurBateau>()
        .HasKey(sc => new { sc.ArmateurId, sc.BateauId });

            modelBuilder.Entity<ArmateurBateau>()
                .HasOne(sc => sc.Armateur)
                .WithMany(s => s.ArmateurBateaus)
                .HasForeignKey(sc => sc.ArmateurId);

            modelBuilder.Entity<ArmateurBateau>()
                .HasOne(sc => sc.Bateau)
                .WithMany(c => c.ArmateurBateaus)
                .HasForeignKey(sc => sc.BateauId);*/



        }


    }
}
