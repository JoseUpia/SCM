using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.Insurance;

namespace SCM.Domain.Context.Configurations
{
    public partial class NetworkTypeConfiguration : IEntityTypeConfiguration<NetworkType>
    {
        public void Configure(EntityTypeBuilder<NetworkType> entity)
        {
            entity.HasKey(e => e.NetworkTypeId).HasName("PK__NetworkT__C09029EE538D704E");

            entity.ToTable("NetworkType", "Insurance");

            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.Description)
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<NetworkType> entity);
    }
}
