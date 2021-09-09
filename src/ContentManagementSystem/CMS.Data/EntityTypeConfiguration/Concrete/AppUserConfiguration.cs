using CMS.Data.EntityTypeConfiguration.Abstract;
using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.EntityTypeConfiguration.Concrete
{
    public class AppUserConfiguration : BaseConfiguration <AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.AppUserId);
            builder.Property(x => x.FullName).HasMaxLength(50).IsRequired(true);


            /*
             One-to-One Relationship between Profile and AppUser
             */
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUsers).HasForeignKey<Profile>(x => x.ProfileId).OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}

