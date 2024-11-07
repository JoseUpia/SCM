using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.system;

namespace SCM.Domain.Context.Configurations
{
    public partial class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> entity)
        {
            entity.HasKey(e => e.StatusId).HasName("PK__Status__C8EE20436105BE6A");

            entity.ToTable("Status", "system");

            entity.HasIndex(e => e.StatusName, "UQ__Status__05E7698AF1550D78").IsUnique();

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusName)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Status> entity);
    }
}
