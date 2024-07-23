using BlazorResortManager1.Data.Models.camera;
using BlazorResortManager1.Data.Models.forecast;
using BlazorResortManager1.Data.Models.main;
using BlazorResortManager1.Data.Models.status;
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

        public DbSet<YrNoCityCode> cityCodes { get; set; }

        public DbSet<Camera> cameras { get; set; }
        public DbSet<CameraResortBinding> cameraResortBindings { get; set; }
        public DbSet<CameraTrackBinding> cameraTrackBindings { get; set; }
        public DbSet<CameraLiftBinding> cameraLiftBindings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => 
                    !fk.GetDefaultName().StartsWith("FK_AspNet") 
                    && !fk.IsOwnership 
                    && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


            //modelBuilder.Entity<LiftStatus>()
            //    .HasOne(l => l.statusSheet)
            //    .WithMany(s => s.liftStatuses)
            //    .HasForeignKey(l => l.statusSheetId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<TrackStatus>()
            //    .HasOne(l => l.statusSheet)
            //    .WithMany(s => s.trackStatuses)
            //    .HasForeignKey(l => l.statusSheetId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ResortStatus>()
            //    .HasOne(l => l.statusSheet)
            //    .WithOne(s => s.resortStatus)
            //    .HasForeignKey<ResortStatus>(l => l.statusSheetId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Resort>()
            //    .HasOne(e => e.yrNoCityCode)
            //    .WithMany(e => e.resorts)
            //    .HasForeignKey(e => e.yrNoCityCodeId);

            //modelBuilder.Entity<YrNoCityCode>()
            //    .HasMany(e => e.resorts)
            //    .WithOne(e => e.yrNoCityCode)
            //    .HasForeignKey(e => e.yrNoCityCodeId)
            //    .HasPrincipalKey(e => e.id);
        }
        //(DbContextOptions<ApplicationDbContext> options) (options)
    }
}
