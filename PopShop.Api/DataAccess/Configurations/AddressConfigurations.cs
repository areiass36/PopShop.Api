using Microsoft.EntityFrameworkCore;
using PopShop.Api.DataContract;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations;
public class AddressConfigurations : IEntityTypeConfiguration<Address>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Endereco", DataContext.SCHEMA)
            .HasKey(e => e.Id)
            .HasName("Id");

        builder.Property(e => e.PostalCode)
               .HasColumnName("Cep")
               .HasMaxLength(8)
               .IsRequired();

        builder.Property(e => e.PublicArea)
               .HasColumnName("Logradouro")
               .HasMaxLength(80)
               .IsRequired();

        builder.Property(e => e.Distric)
               .HasColumnName("Bairro")
               .HasMaxLength(80)
               .IsRequired();

        builder.Property(e => e.City)
               .HasColumnName("Cidade")
               .HasMaxLength(40)
               .IsRequired();

        builder.Property(e => e.State)
               .HasColumnName("Uf")
               .HasMaxLength(2)
               .IsRequired();

        builder.Property(e => e.Number)
               .HasColumnName("Numero")
               .HasMaxLength(20)
               .IsRequired();

        builder.Property(e => e.Complement)
               .HasColumnName("Complemento")
               .HasMaxLength(100);

        builder.HasOne<User>().WithMany(e => e.Addresses);
    }
}
