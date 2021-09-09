﻿using CMS.Data.EntityTypeConfiguration.Abstract;
using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.EntityTypeConfiguration.Concrete
{
    public class TagConfiguration : BaseConfiguration <Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(x => x.TagId);
            builder.Property(x => x.TagName).HasMaxLength(50).IsRequired(true);
            base.Configure(builder);
        }
    }
}

