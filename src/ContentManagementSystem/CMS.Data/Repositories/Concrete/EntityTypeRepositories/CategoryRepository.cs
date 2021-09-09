using CMS.Data.Context;
using CMS.Data.Repositories.Concrete.BaseRepository;
using CMS.Data.Repositories.Interface.IEntityTypeRepositories;
using CMS.Entity.Entities.Concrete;

namespace CMS.Data.Repositories.Concrete.EntityTypeRepositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}

