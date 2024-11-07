using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.users;

namespace SCM.Domain.Context.Configurations
{
    public partial class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> entity)
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC346B158B7FB");

            entity.ToTable("Patients", "users");

            entity.Property(e => e.PatientId)
            .ValueGeneratedNever()
            .HasColumnName("PatientID");
            entity.Property(e => e.Address)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.Allergies).IsRequired();
            entity.Property(e => e.BloodType)
            .IsRequired()
            .HasMaxLength(2)
            .IsUnicode(false)
            .IsFixedLength();
            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.EmergencyContactName)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.EmergencyContactPhone)
            .IsRequired()
            .HasMaxLength(15)
            .IsUnicode(false);
            entity.Property(e => e.Gender)
            .IsRequired()
            .HasMaxLength(1)
            .IsUnicode(false)
            .IsFixedLength();
            entity.Property(e => e.InsuranceProviderId).HasColumnName("InsuranceProviderID");
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15)
            .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Patient> entity);
    }
}
