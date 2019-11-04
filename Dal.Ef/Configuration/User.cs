using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class User : IEntityTypeConfiguration<Domain.Entities.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.HasOne(p => p.City).WithMany().HasForeignKey(p => p.CityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}