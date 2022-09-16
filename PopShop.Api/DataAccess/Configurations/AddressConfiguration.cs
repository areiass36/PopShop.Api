using Microsoft.EntityFrameworkCore;
using PopShop.Api.DataContract;

namespace PopShop.Api.DataAccess.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address", DataContext.SCHEMA)
                .HasKey(e => e.Id)
                .HasName("Id");
        }
    }
}
