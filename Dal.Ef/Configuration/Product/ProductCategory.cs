using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class ProductCategory : IEntityTypeConfiguration<Domain.Entities.ProductCategory>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.ProductCategory> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).IsRequired();
        }
    }
}