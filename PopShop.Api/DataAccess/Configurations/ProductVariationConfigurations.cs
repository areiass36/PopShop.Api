using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.DataAccess;
using PopShop.Api.Models;

namespace PopShop.Api.Configurations;

public class ProductVariationConfigurations : IEntityTypeConfiguration<ProductVariation>
{
    public void Configure(EntityTypeBuilder<ProductVariation> builder)
    {
        builder.ToTable("ProdutoVariacao", DataContext.SCHEMA)
               .HasKey(e => e.Id)
               .HasName("Id");

        builder.Property(e => e.Name)
               .HasColumnName("Variacao")
               .IsRequired()
               .HasMaxLength(60);

        builder.HasOne<Product>().WithMany(e => e.Variations);
    }
}