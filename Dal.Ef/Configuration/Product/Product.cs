using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Product : IEntityTypeConfiguration<Domain.Entities.Product>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Product> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.ProductCategoryId).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.IsSpecial).IsRequired();
            builder.Property(p => p.IsImmediate).IsRequired();
            builder.Property(p => p.IsAdvertisement).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.HasOne(p => p.ProductCategory).WithMany().HasForeignKey(p => p.ProductCategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.City).WithMany().HasForeignKey(p => p.CityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.User).WithMany(q=> q.Product).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}