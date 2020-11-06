using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Week8Project.Core.Exceptions.Repositories
{
    public interface IPriceListRepository<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
       Task<T> AddPriceList(PriceListAdd pricelist);
    }
}
