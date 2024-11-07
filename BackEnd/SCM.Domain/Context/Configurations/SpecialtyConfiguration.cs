using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.medical;

namespace SCM.Domain.Context.Configurations
{
    public partial class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> entity)
        {
            entity.HasKey(e => e.SpecialtyId).HasName("PK__Specialt__D768F6483D915F1C");

            entity.ToTable("Specialties", "medical");

            entity.HasIndex(e => e.SpecialtyName, "UQ__Specialt__7DCA57487C1C2729").IsUnique();

            entity.Property(e => e.SpecialtyId).HasColumnName("SpecialtyID");
            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.SpecialtyName)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.UpdatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Specialty> entity);
    }
}
