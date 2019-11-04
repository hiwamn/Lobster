using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class LastVisitedProduct : IEntityTypeConfiguration<Domain.Entities.LastVisitedProduct>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.LastVisitedProduct> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Product).WithMany().HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.User).WithMany(p=>p.LastVisitedProduct).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}