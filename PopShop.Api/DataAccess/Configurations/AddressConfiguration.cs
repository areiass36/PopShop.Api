using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.DataAccess;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address", DataContext.SCHEMA)
            .HasKey(e => e.Id)
            .HasName("Id");

            builder.Property(e => e.PublicArea)
            .HasColumnName("logradouro")
            .IsRequired()
            .HasMaxLength(150);

            builder.Property(e => e.Complement)
           .HasColumnName("complemento")
           .IsRequired()
           .HasMaxLength(150);

            builder.Property(e => e.Distric)
           .HasColumnName("bairro")
           .IsRequired()
           .HasMaxLength(150);

            builder.Property(e => e.City)
           .HasColumnName("localidade")
           .IsRequired()
           .HasMaxLength(150);

            builder.Property(e => e.State)
           .HasColumnName("uf")
           .IsRequired()
           .HasMaxLength(150);
        }
    }
}
