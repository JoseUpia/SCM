using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.system;

namespace SCM.Domain.Context.Configurations
{
    public partial class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> entity)
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E325F9132A4");

            entity.ToTable("Notifications", "system");

            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.Message)
            .IsRequired()
            .HasColumnType("text");
            entity.Property(e => e.SentAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Notification> entity);
    }
}
