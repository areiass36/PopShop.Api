using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.DataAccess;
using PopShop.Api.Models;

namespace PopShop.Api.Configurations;

public class ProductPhotoConfigurations : IEntityTypeConfiguration<ProductPhoto>
{
    public void Configure(EntityTypeBuilder<ProductPhoto> builder)
    {
        builder.ToTable("ProdutoFoto", DataContext.SCHEMA)
               .HasKey(e => e.Id)
               .HasName("Id");

        builder.Property(e => e.PhotoUrl)
               .HasColumnName("FotoUrl")
               .IsRequired();

        builder.HasOne<Product>().WithMany(e => e.Photos);
    }
}