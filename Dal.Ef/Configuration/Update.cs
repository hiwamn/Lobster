using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Update : IEntityTypeConfiguration<Domain.Entities.Update>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Update> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Restricted).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.Property(p => p.Version).IsRequired();
            builder.Property(p => p.Link).IsRequired();

        }
    }
}