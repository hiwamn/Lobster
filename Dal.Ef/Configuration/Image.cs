
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Image : IEntityTypeConfiguration<Domain.Entities.Image>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Image> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Location).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();

        }
    }
}