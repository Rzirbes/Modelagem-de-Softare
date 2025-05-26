using System.Collections.Generic;
using System.Threading.Tasks;
using APIDOJO.Interfaces;
using APIDOJO.Interfaces.Repositories;
using APIDOJO.Models;

namespace APIDOJO.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public async Task<Livro> Add(Livro livro)
        {
            return await _livroRepository.Add(livro);
        }

        public async Task<List<Livro>> GetAll()
        {
            var livros = await _livroRepository.GetAll();
            return livros.ToList();
        }

        public async Task<Livro?> GetById(int id)
        {
            return await _livroRepository.GetById(id);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _livroRepository.Delete(id);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }

        public async Task<Livro?> Update(int id, Livro livro)
        {
            try
            {
                return await _livroRepository.Update(id, livro);
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
