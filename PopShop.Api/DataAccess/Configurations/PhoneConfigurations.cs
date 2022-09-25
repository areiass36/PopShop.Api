using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations;

public class PhoneConfigurations : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder.ToTable("Telefone", DataContext.SCHEMA)
               .HasKey(e => e.Id)
               .HasName("Id");

        builder.Property(e => e.UserId)
               .HasColumnName("Usuario")
               .IsRequired();

        builder.Property(e => e.Code)
               .HasColumnName("Ddd")
               .HasMaxLength(2)
               .IsRequired();

        builder.Property(e => e.Number)
               .HasColumnName("Numero")
               .HasMaxLength(9)
               .IsRequired();

        builder.HasOne<User>().WithMany().HasForeignKey(e => e.UserId);

    }
}