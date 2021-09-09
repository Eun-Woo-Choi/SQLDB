using CMS.Entity.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CMS.Data.Repositories.Interface.IBaseRepository
{
    public interface IBaseRepository<T> where T : class, IBaseEntity
    {
        Task<List<T>> GetAll();
        Task<List<T>> GetByDefaults(Expression<Func<T, bool>> expression);

        Task<T> GetByDefault(Expression<Func<T, bool>> expression);
        Task<T> GetById(int Id);

        Task<bool> Any(Expression<Func<T, bool>> expression);

        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}

