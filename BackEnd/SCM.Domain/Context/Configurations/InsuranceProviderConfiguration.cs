using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.Insurance;

namespace SCM.Domain.Context.Configurations
{
    public partial class InsuranceProviderConfiguration : IEntityTypeConfiguration<InsuranceProvider>
    {
        public void Configure(EntityTypeBuilder<InsuranceProvider> entity)
        {
            entity.ToTable("InsuranceProviders", "Insurance");

            entity.Property(e => e.InsuranceProviderId).HasColumnName("InsuranceProviderID");
            entity.Property(e => e.AcceptedRegions)
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.Address)
            .IsRequired()
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.City)
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.Country)
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.CoverageDetails)
            .IsRequired()
            .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.CustomerSupportContact)
            .HasMaxLength(15)
            .IsUnicode(false);
            entity.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.IsActive)
            .IsRequired()
            .HasDefaultValueSql("((1))");
            entity.Property(e => e.LogoUrl)
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.MaxCoverageAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15)
            .IsUnicode(false);
            entity.Property(e => e.State)
            .HasMaxLength(100)
            .IsUnicode(false);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.Website)
            .HasMaxLength(255)
            .IsUnicode(false);
            entity.Property(e => e.ZipCode)
            .HasMaxLength(10)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<InsuranceProvider> entity);
    }
}
