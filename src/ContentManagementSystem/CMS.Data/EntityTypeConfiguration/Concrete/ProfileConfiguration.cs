using CMS.Data.EntityTypeConfiguration.Abstract;
using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.EntityTypeConfiguration.Concrete
{
    public class ProfileConfiguration : BaseConfiguration <Profile>
    {
        public override void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(x => x.ProfileId);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired(true);
            base.Configure(builder);
        }
    }
}

