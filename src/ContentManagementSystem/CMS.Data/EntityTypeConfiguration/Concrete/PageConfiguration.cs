using CMS.Data.EntityTypeConfiguration.Abstract;
using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.EntityTypeConfiguration.Concrete
{
    public class PageConfiguration : BaseConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasKey(x => x.PageId);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Content).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Slug).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Sorting).IsRequired(false);

            base.Configure(builder);
        }
    }
}

