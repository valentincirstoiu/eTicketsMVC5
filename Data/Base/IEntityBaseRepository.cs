using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;
using eTicketsMVC5.Models;

namespace eTicketsMVC5.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
