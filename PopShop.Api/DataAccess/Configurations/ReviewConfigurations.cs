using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations;

public class ReviewConfigurations : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("ProdutoAvaliacao", DataContext.SCHEMA);

        builder.HasKey(e => new { e.ProductId, e.UserId });

        builder.Property(e => e.Text)
               .IsRequired();

        builder.Property(e => e.Grade)
               .IsRequired();
    }
}