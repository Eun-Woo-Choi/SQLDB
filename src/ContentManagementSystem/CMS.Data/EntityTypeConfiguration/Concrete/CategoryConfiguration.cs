using CMS.Data.EntityTypeConfiguration.Abstract;
using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.EntityTypeConfiguration.Concrete
{
    public class CategoryConfiguration : BaseConfiguration <Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(50).IsRequired(false);
            base.Configure(builder);
        }
    }
}

