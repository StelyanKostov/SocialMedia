using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

        

    }
}
