using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class City : IEntityTypeConfiguration<Domain.Entities.City>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.City> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).IsRequired();
            builder.HasOne(p => p.Province).WithMany(p=>p.City).HasForeignKey(p => p.ProvinceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}