using Microsoft.EntityFrameworkCore;
using WebServiceFactoryModel.Entities;

namespace WebServiceFactoryInfrastructure.Database
{
    public class AppDbContext : DbContext
    {
        //private readonly IConfiguration _configuration;

        //public AppDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public DbSet<Region> Regions { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<TechUnit> TechUnits { get; set; }
        public DbSet<EquipmentGroup> EquipmentGroups { get; set; }
        public DbSet<Hardware> Hardwares { get; set; }
        public DbSet<HardwareType> HardwareTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DockerConnection"));
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder) //это че конфигурайия бд
        //{
        //    modelBuilder.Entity<Facility>(facilityBuilder =>
        //    {
        //        facilityBuilder.ToTable("Facilities").HasKey(k => k.Id);
        //        facilityBuilder.Property(facilityBuilder => facilityBuilder.Title).IsRequired().HasMaxLength(255);
        //        facilityBuilder.Property(facilityBuilder => facilityBuilder.Description).IsRequired().HasMaxLength(255);
        //        facilityBuilder.Property(facilityBuilder => facilityBuilder.ShortTitle).IsRequired().HasMaxLength(255);
        //        facilityBuilder
        //        .HasOne(r => r.Region)
        //        .WithMany(f => f.Facilities)
        //        .HasForeignKey(r => r.RegionId);

        //    });

        //    modelBuilder.Entity<TechUnit>(techUnitBuilder =>
        //    {
        //        techUnitBuilder.ToTable("TechUnits").HasKey(k => k.Id);
        //        techUnitBuilder.Property(techUnitBuilder=> techUnitBuilder.Title).IsRequired().HasMaxLength(255);   
        //        techUnitBuilder.Property(techUnitBuilder=> techUnitBuilder.Description).IsRequired().HasMaxLength(255);   
        //        techUnitBuilder.Property(techUnitBuilder=> techUnitBuilder.ShortTitle).IsRequired().HasMaxLength(255);
        //        techUnitBuilder
        //        .HasOne(f => f.Facility)
        //        .WithMany(t => t.TechUnits)
        //        .HasForeignKey(f => f.FacilityId);
        //    });

        //    modelBuilder.Entity<EquipmentGroup>(equipmentGroupBuilder =>
        //    {
        //        equipmentGroupBuilder.ToTable("EquipmentGroups").HasKey(k=>k.Id);
        //        equipmentGroupBuilder.Property(equipmentGroupBuilder => equipmentGroupBuilder.Title).IsRequired().HasMaxLength(255);
        //        equipmentGroupBuilder.Property(equipmentGroupBuilder => equipmentGroupBuilder.Description).IsRequired().HasMaxLength(255);
        //        equipmentGroupBuilder.Property(equipmentGroupBuilder => equipmentGroupBuilder.ShortTitle).IsRequired().HasMaxLength(255);
        //        equipmentGroupBuilder
        //        .HasOne(e => e.TechUnit)
        //        .WithMany(t => t.EquipmentGroups)
        //        .HasForeignKey(e => e.TechUnitId);
        //    });

        //    modelBuilder.Entity<Hardware>(hardwareBuilder =>
        //    {
        //        hardwareBuilder.ToTable("Hardwares").HasKey(k => k.Id);
        //        hardwareBuilder.Property(hardwareBuilder => hardwareBuilder.Title).IsRequired().HasMaxLength(255);
        //        hardwareBuilder.Property(hardwareBuilder => hardwareBuilder.Description).IsRequired().HasMaxLength(255);
        //        hardwareBuilder.Property(hardwareBuilder => hardwareBuilder.ShortDescription).IsRequired().HasMaxLength(255);
        //        hardwareBuilder
        //        .HasOne(h => h.EquipmentGroup)
        //        .WithMany(e => e.Hardwares)
        //        .HasForeignKey(h => h.EquipmentGroupId);

        //        hardwareBuilder
        //        .HasOne(h=>h.HardwareType)
        //        .WithMany(ht=> ht.Hardwares)
        //        .HasForeignKey(h=>h.HardwareTypeId);

        //    });

        //}
    }
}
