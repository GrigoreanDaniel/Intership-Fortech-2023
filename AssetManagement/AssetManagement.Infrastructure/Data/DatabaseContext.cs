using AssetManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<HardwareDeviceEntity> HardwareDevices { get; set; }
        public DbSet<HardwareDeviceType> HardwareDevicesTypes { get; set; }
        public DbSet<SoftwareTypeEntity> Softwares { get; set; }
        public DbSet<SoftwareLicenseEntity> SoftwareLicenses { get; set; }
        public DbSet<SupervisorEmployeeEntity> SupervisorsEmployees { get; set; }
        public DbSet<UserHardwareDeviceEntity> UserHardwareDevices { get; set; }
        public DbSet<UserSoftwareLicenseEntity> UserSoftwareLicenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>()
                .HasMany(c => c.UserHardwareDevices)
                .WithOne(h => h.Customer)
                .HasForeignKey(h => h.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.UserHardwareDevices)
                .WithOne(h => h.Employee)
                .HasForeignKey(h => h.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.UserSoftwareLicenses)
                .WithOne(s => s.Employee)
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HardwareDeviceType>()
                .HasMany(h => h.HardwareDevices)
                .WithOne(t => t.HardwareDeviceType)
                .HasForeignKey(t => t.HardwareDeviceTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SoftwareTypeEntity>()
                .HasMany(l => l.Licenses)
                .WithOne(s => s.SoftwareType)
                .HasForeignKey(s => s.SoftwareTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupervisorEmployeeEntity>()
                .HasKey(se => new { se.SupervisorId, se.EmployeeId });

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(e => e.Supervisors)
                .WithOne(se => se.Employee)
                .HasForeignKey(se => se.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EmployeeEntity>()
                .HasMany(s => s.BelowEmployees)
                .WithOne(se => se.Supervisor)
                .HasForeignKey(se => se.SupervisorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserSoftwareLicenseEntity>()
                .HasOne(u => u.SoftwareLicense)
                .WithOne(s => s.UserSoftwareLicense)
                .HasForeignKey<UserSoftwareLicenseEntity>(u => u.SoftwareLicenseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserHardwareDeviceEntity>()
                .HasOne(u => u.HardwareDevice)
                .WithOne(h => h.UserHardwareDevice)
                .HasForeignKey<UserHardwareDeviceEntity>(u => u.HardwareDeviceId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}