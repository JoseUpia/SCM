using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.medical;

namespace SCM.Domain.Context.Configurations
{
    public partial class MedicalRecordConfiguration : IEntityTypeConfiguration<MedicalRecord>
    {
        public void Configure(EntityTypeBuilder<MedicalRecord> entity)
        {
            entity.HasKey(e => e.RecordId).HasName("PK__MedicalR__FBDF78C96E650FFC");

            entity.ToTable("MedicalRecords", "medical");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.DateOfVisit).HasColumnType("datetime");
            entity.Property(e => e.Diagnosis)
            .IsRequired()
            .HasColumnType("text");
            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.Treatment)
            .IsRequired()
            .HasColumnType("text");
            entity.Property(e => e.UpdatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<MedicalRecord> entity);
    }
}
