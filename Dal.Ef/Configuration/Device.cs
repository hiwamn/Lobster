using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Device : IEntityTypeConfiguration<Domain.Entities.Device>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Device> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.PushId).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.HasOne(p=>p.User).WithMany(b => b.Device).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}