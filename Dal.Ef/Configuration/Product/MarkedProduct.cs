using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class MarkedProduct : IEntityTypeConfiguration<Domain.Entities.MarkedProduct>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.MarkedProduct> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.Product).WithMany(p=>p.MarkedProducts).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.User).WithMany(p => p.MarkedProduct).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);


        }
    }
}