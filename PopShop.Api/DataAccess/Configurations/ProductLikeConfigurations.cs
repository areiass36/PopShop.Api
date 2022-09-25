using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations;

public class ProductLikeConfigurations : IEntityTypeConfiguration<ProductLike>
{
    public void Configure(EntityTypeBuilder<ProductLike> builder)
    {
        builder.ToTable("ProdutoGostei", DataContext.SCHEMA);

        builder.HasKey(e => new { e.ProductId, e.UserId });

        builder.HasMany<User>().WithOne();
        builder.HasMany<Store>().WithOne();
    }
}