using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVetAPI.Interfaces
{
    public interface IBaseService<T>
    {
        Task<List<T>> GetAll();
        Task<T?> GetById(int id);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
        Task<T?> Update(int id, T entity);
    }
}