using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace SocialMedia.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Profils> Profils { get; set; }

        public DbSet<Image> images { get; set; }

        public DbSet<Messages> Messages { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Likes> Likes { get; set; }

        public DbSet<ChatRooms> ChatRooms { get; set; }

        public DbSet<RealTimeChat> RealTimeChat { get; set; }

        public DbSet<RouteChat> RouteChat { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(b => b.Profil)
                .WithOne(i => i.ApplicationUser)
                .HasForeignKey<Profils>(b => b.ApplicationUserId);


            Seed(modelBuilder);
        }

        public void Seed(ModelBuilder builder)
        {


            string ADMIN_ID = Guid.NewGuid().ToString();
            string ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            var appUser = new ApplicationUser
            {
                Id = ADMIN_ID,
                Email = "Admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                UserName = "Admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                SecurityStamp = "AZVMXEHBSG3MTISR6RY6Y2IYTVD7SLKV",
                ConcurrencyStamp = "8a35ff0f-341e-481a-971d-f2cf3cba3e02",
              
                
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Admin12345");

            builder.Entity<ApplicationUser>().HasData(appUser);
            builder.Entity<Profils>().HasData(new Data.Profils
            {
                ApplicationUserId = ADMIN_ID,
                id = 1,
                UserName = "Admin"
                

            });


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }

        

    }
}
