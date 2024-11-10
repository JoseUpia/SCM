using Microsoft.EntityFrameworkCore;
using SCM.Domain.Entities.appointments;
using SCM.Domain.Entities.Insurance;
using SCM.Domain.Entities.medical;
using SCM.Domain.Entities.system;
using SCM.Domain.Entities.users;

namespace SCM.Domain.Context;

public partial class HealtSyncContext : DbContext
{
    public HealtSyncContext()
    {
    }

    public HealtSyncContext(DbContextOptions<HealtSyncContext> options)
        : base(options)
    {
    }

    #region "DbSet"
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AvailabilityMode> AvailabilityModes { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<InsuranceProvider> InsuranceProviders { get; set; }
    public DbSet<MedicalRecord> MedicalRecords { get; set; }
    public DbSet<NetworkType> NetworkTypes { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<User> Users { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new Configurations.AppointmentConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.AvailabilityModeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DoctorConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.DoctorAvailabilityConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.InsuranceProviderConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.MedicalRecordConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.NetworkTypeConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.NotificationConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PatientConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.PersonConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.RoleConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.SpecialtyConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.StatusConfiguration());
        modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
