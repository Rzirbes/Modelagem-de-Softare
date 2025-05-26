using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Services;
using APIDOJO.Models;

namespace APIDOJO.Interfaces.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> GetAll();
        Task<Livro?> GetById(int id);
        Task<Livro> Add(Livro livro);
        Task<Livro> Update(int id, Livro livro);
        Task Delete(int id);
    }
}