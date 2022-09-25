using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations
{
    public class StoreConfigurations : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ToTable("Loja", DataContext.SCHEMA)
                .HasKey(e => e.Id)
                .HasName("Id");

            builder.Property(e => e.Name)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.Description)
                .HasColumnName("Descricao")
                .IsRequired()
                .HasMaxLength(255);

            builder.HasKey(e => e.PhotoUrl)
                .HasName("FotoUrl");

            builder.HasOne<User>().WithOne();

            builder.HasMany<StoreLike>().WithOne();

        }
    }
}
