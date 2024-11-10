using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCM.Domain.Entities.users;

namespace SCM.Domain.Context.Configurations
{
    public partial class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> entity)
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Persons__AA2FFB85B9C34B6B");

            entity.ToTable("Persons", "users");

            entity.Property(e => e.PersonId)
            .ValueGeneratedNever()
            .HasColumnName("PersonID");
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.FirstName)
            .HasMaxLength(40)
            .IsUnicode(false);
            entity.Property(e => e.Gender)
            .HasMaxLength(1)
            .IsUnicode(false)
            .IsFixedLength();
            entity.Property(e => e.IdentificationNumber)
            .HasMaxLength(25)
            .IsUnicode(false);
            entity.Property(e => e.LastName)
            .HasMaxLength(40)
            .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Person> entity);
    }
}
