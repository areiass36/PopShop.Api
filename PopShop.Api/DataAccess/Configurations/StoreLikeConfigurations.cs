using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations;

public class StoreLikeConfigurations : IEntityTypeConfiguration<StoreLike>
{
    public void Configure(EntityTypeBuilder<StoreLike> builder)
    {
        builder.ToTable("LojaGostei", DataContext.SCHEMA);

        builder.HasKey(e => new { e.StoreId, e.UserId });

        builder.HasMany<User>().WithOne();
        builder.HasMany<Store>().WithOne();

    }
}