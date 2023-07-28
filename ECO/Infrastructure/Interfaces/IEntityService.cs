using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    // T : DTO Queries ,  H : DTO Commands , K is type Id
    public interface IEntityService<T, H, K> 
        where T : class
        where H : class
    {
        Task<List<T>> GetAll();
        Task<T> FindById(K id);
        Task Add(H entity);
        Task<T> CreateAndGet(H entity);
        Task Update(H entity);
        Task Remove(K id);
    }
}
