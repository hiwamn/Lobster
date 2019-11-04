using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class Notification : IEntityTypeConfiguration<Domain.Entities.Notification>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Notification> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Text).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.Property(p => p.UserId).IsRequired();
            builder.HasOne(p => p.User).WithMany(b => b.Notification).HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(p => p.Device).WithMany(b => b.Notification).HasForeignKey(p => p.DeviceId).OnDelete(DeleteBehavior.ClientRestrict);

        }
    }
}