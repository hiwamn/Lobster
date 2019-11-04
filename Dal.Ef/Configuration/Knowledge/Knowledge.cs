using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Knowledge : IEntityTypeConfiguration<Domain.Entities.Knowledge>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Knowledge> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Description).IsRequired();            

        }
    }
}