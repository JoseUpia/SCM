using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.users;

namespace SCM.Domain.Context.Configurations
{
    public partial class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> entity)
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__2DC00EDFCF31D9E9");

            entity.ToTable("Doctors", "users");

            entity.Property(e => e.DoctorId)
            .ValueGeneratedNever()
            .HasColumnName("DoctorID");
            entity.Property(e => e.ClinicAddress)
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.ConsultationFee).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.Education).IsRequired();
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.LicenseExpirationDate).HasColumnType("date");
            entity.Property(e => e.LicenseNumber)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15)
            .IsUnicode(false);
            entity.Property(e => e.SpecialtyId).HasColumnName("SpecialtyID");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Doctor> entity);
    }
}
