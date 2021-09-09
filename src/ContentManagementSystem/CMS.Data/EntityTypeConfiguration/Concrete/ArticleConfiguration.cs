using CMS.Data.EntityTypeConfiguration.Abstract;
using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.EntityTypeConfiguration.Concrete
{
    public class ArticleConfiguration : BaseConfiguration <Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.ArticleId);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(50).IsRequired(true);

            /*
             One-to-Many Relationships with AppUser(O), Category, Comment and Tag. 
             */
            // AppUser
            builder.HasOne(x => x.AppUser).WithMany(x => x.Articles).HasForeignKey(x => x.AppUserId).OnDelete(DeleteBehavior.Restrict);
            // Category
            builder.HasOne(x => x.Category).WithMany(x => x.Articles).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
            // Comment
            builder.HasOne(x => x.Comment).WithMany(x => x.Articles).HasForeignKey(x => x.CommentId).OnDelete(DeleteBehavior.Restrict);
            // Tag
            builder.HasOne(x => x.Tag).WithMany(x => x.Articles).HasForeignKey(x => x.TagId).OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}

