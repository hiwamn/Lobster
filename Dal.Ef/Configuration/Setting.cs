using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Setting : IEntityTypeConfiguration<Domain.Entities.Setting>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Setting> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Value).IsRequired();
        }
    }
}