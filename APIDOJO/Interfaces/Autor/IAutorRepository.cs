using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Models;

namespace APIDOJO.Interfaces.Repositories
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAll();
        Task<Autor?> GetById(int id);
        Task<Autor> Add(Autor autor);
        Task<Autor> Update(int id, Autor autor);
        Task Delete(int id);
    }
}