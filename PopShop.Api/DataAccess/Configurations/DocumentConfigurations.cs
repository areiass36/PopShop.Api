using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.Models;

namespace PopShop.Api.DataAccess.Configurations
{
    public class DocumentConfigurations : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documento", DataContext.SCHEMA)
               .HasKey(e => e.UserId)
               .HasName("Usuario");

            builder.Property(e => e.Type)
                   .HasColumnName("Tipo")
                   .IsRequired();

            builder.Property(e => e.Value)
                   .HasColumnName("Documento")
                   .IsRequired()
                   .HasMaxLength(14);

            builder.HasOne<User>().WithOne(e => e.Document);
        }
    }

}
