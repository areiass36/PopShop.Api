using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopShop.Api.DataAccess;
using PopShop.Api.Models;


namespace PopShop.Api.DataAccess.Configurations
{
    public class TelephoneConfiguration: IEntityTypeConfiguration<Telephone>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Telephone> builder)
        {
            builder.ToTable("Telephone", DataContext.SCHEMA)
                .HasKey(e => e.Id)
                .HasName("Id");
            
            //Ver com Augusto esse campo
          /*  builder.Property(e => e.Usuario)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength();*/

            builder.Property(e => e.Ddd)
                .HasColumnName("Ddd")
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(e => e.Numero)
                .HasColumnName("Numero")
                .IsRequired()
                .HasMaxLength(9);
        }
    }
}
