using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Province : IEntityTypeConfiguration<Domain.Entities.Province>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Province> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).IsRequired();
        }
    }
}