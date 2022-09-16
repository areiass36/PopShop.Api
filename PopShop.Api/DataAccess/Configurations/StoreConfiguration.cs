using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.DataContract;

namespace PopShop.Api.DataAccess.Configurations
{
    public class StoreConfiguration : IEntityTypeConfiguration<Store>
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
                .HasMaxLength(80);

            builder.HasKey(e => e.PhotoUrl)
                .HasName("FotoUrl");

        }
    }
}
