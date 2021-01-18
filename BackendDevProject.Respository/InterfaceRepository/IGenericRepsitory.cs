using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendDevProject.Respository.InterfaceRepository
{
    public interface IGenericRepsitory<T> where T : class
    {
        Task<T> Get(int id);

        Task<IEnumerable<T>> GetAll();

        Task<bool> Create(T entity);

        Task<bool> Delete(int id);

        Task<bool> Update(T entity);

    }
}
