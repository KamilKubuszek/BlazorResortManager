using BlazorResortManager1.main;
using BlazorResortManager1.status;
using BlazorResortManager1.user;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorResortManager1.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Permit> permits { get; set; } 
        public DbSet<TrackStatus> trackStatuses { get; set; }
        public DbSet<ResortStatus> resortStatuses { get; set; }
        public DbSet<LiftStatus> liftStatuses { get; set; }
        public DbSet<StatusSheet> statusSheets { get; set; }

        public DbSet<Resort> resorts { get; set; }
        public DbSet<Track> tracks { get; set; } 
        public DbSet<Lift> lifts { get; set; } 

        public DbSet<ResortParameter> resortParameters { get; set; } 
        public DbSet<LiftParameter> liftParameters { get; set; } 
        public DbSet<TrackParameter> trackParameters { get; set; } 

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<LiftStatus>()
                .HasOne(l => l.statusSheet)
                .WithMany(s => s.liftStatuses)
                .HasForeignKey(l => l.statusSheetId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TrackStatus>()
                .HasOne(l => l.statusSheet)
                .WithMany(s => s.trackStatuses)
                .HasForeignKey(l => l.statusSheetId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResortStatus>()
                .HasOne(l => l.statusSheet)
                .WithOne(s => s.resortStatus)
                .HasForeignKey<ResortStatus>(l => l.statusSheetId)
                .OnDelete(DeleteBehavior.Restrict);

        }
        //(DbContextOptions<ApplicationDbContext> options) (options)
    }
}
