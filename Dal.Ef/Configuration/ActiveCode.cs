using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class ActiveCode : IEntityTypeConfiguration<Domain.Entities.ActiveCode>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.ActiveCode> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.Code).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Mobile).IsRequired().HasMaxLength(11);
            builder.Property(p => p.RegisterDate).IsRequired();
            //builder.HasOne(p => p.ActiveCodeType).WithMany(b => b.ActiveCode).HasForeignKey(p => p.ActiveCodeTypeID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}