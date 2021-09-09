using CMS.Data.Context;
using CMS.Data.Repositories.Concrete.BaseRepository;
using CMS.Data.Repositories.Interface.IEntityTypeRepositories;
using CMS.Entity.Entities.Concrete;

namespace CMS.Data.Repositories.Concrete.EntityTypeRepositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}

