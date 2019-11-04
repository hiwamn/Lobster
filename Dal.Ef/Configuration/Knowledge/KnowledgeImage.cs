using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dal.Ef.Configuration
{
    public class KnowledgeImage : IEntityTypeConfiguration<Domain.Entities.KnowledgeImage>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.KnowledgeImage> builder)
        {
            builder.HasKey(p => new { p.Id });
            builder.Property(p => p.KnowledgeId).IsRequired();
            builder.Property(p => p.RegisterDate).IsRequired();
            builder.Property(p => p.ImageId).IsRequired();
            builder.HasOne(p => p.Knowledge).WithMany(b => b.KnowledgeImage).HasForeignKey(p => p.KnowledgeId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}