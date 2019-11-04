using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class WeatherPoint : IEntityTypeConfiguration<Domain.Entities.WeatherPoint>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.WeatherPoint> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Lat).IsRequired();
            builder.Property(p => p.Lon).IsRequired();
        }
    }
}