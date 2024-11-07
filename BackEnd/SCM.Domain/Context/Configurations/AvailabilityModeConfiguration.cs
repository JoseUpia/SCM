using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.medical;

namespace SCM.Domain.Context.Configurations
{
    public partial class AvailabilityModeConfiguration : IEntityTypeConfiguration<AvailabilityMode>
    {
        public void Configure(EntityTypeBuilder<AvailabilityMode> entity)
        {
            entity.HasKey(e => e.AvailabilityModeId).HasName("PK__Availabi__A1FC32EB8575287F");

            entity.ToTable("AvailabilityModes", "medical");

            entity.HasIndex(e => e.AvailabilityMode1, "UQ__Availabi__8598C8501DA7BCD0").IsUnique();

            entity.Property(e => e.AvailabilityModeId).HasColumnName("AvailabilityModeID");
            entity.Property(e => e.AvailabilityMode1)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("AvailabilityMode");
            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.UpdatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AvailabilityMode> entity);
    }
}
