using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Usuario", DataContext.SCHEMA)
               .HasKey(e => e.Id)
               .HasName("Id");

        builder.Property(e => e.Name)
               .HasColumnName("Nome")
               .IsRequired()
               .HasMaxLength(30);

        builder.Property(e => e.LastName)
               .HasColumnName("Sobrenome")
               .IsRequired()
               .HasMaxLength(80);

        builder.Property(e => e.Email)
               .HasColumnName("Email")
               .IsRequired()
               .HasMaxLength(80);

        builder.Property(e => e.Password)
               .HasColumnName("Senha")
               .IsRequired();

        builder.Property(e => e.Role)
               .HasColumnName("Cargo")
               .IsRequired();

        builder.Property(e => e.PhotoUrl)
               .HasColumnName("FotoUrl")
               .IsRequired();

        builder.Property(e => e.CreationDate)
               .HasColumnName("DataCriacao")
               .IsRequired();

        builder.Property(e => e.Active)
               .HasColumnName("Ativo")
               .IsRequired();
    }

}