using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class ProductImage : IEntityTypeConfiguration<Domain.Entities.ProductImage>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.ProductImage> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.Property(p => p.ImageId).IsRequired();
            builder.HasOne(p => p.Product).WithMany(b => b.ProductImage).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}