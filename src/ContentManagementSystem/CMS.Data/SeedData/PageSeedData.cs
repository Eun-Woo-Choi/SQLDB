using CMS.Entity.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Data.SeedData
{
    public class PageSeedData : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasData(
                new Page { PageId = 1, Title = "Home", Content = "Home Page", Slug = "home", Sorting = 100},
                new Page { PageId = 2, Title = "Contact Us", Content = "Contact Us Page", Slug = "contact_us", Sorting = 100},
                new Page { PageId = 3, Title = "Service", Content = "Service Page", Slug = "service", Sorting = 100},
                new Page { PageId = 4, Title = "About Us", Content = "About Us Page", Slug = "about_us", Sorting = 100}
                );
        }
    }
}

