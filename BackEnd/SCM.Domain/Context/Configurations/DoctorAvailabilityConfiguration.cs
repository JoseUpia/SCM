using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.appointments;

namespace SCM.Domain.Context.Configurations
{
    public partial class DoctorAvailabilityConfiguration : IEntityTypeConfiguration<DoctorAvailability>
    {
        public void Configure(EntityTypeBuilder<DoctorAvailability> entity)
        {
            entity.HasKey(e => e.AvailabilityId).HasName("PK__DoctorAv__DA3979910DC5B8A1");

            entity.ToTable("DoctorAvailability", "appointments");

            entity.Property(e => e.AvailabilityId).HasColumnName("AvailabilityID");
            entity.Property(e => e.AvailableDate).HasColumnType("date");
            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<DoctorAvailability> entity);
    }
}
