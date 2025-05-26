using System.Collections.Generic;
using System.Threading.Tasks;
using APIDOJO.Interfaces;
using APIDOJO.Interfaces.Repositories;
using APIDOJO.Models;

namespace APIDOJO.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public async Task<Autor> Add(Autor autor)
        {
            return await _autorRepository.Add(autor);
        }

        public async Task<List<Autor>> GetAll()
        {
            var autores = await _autorRepository.GetAll();
            return autores.ToList();
        }

        public async Task<Autor?> GetById(int id)
        {
            return await _autorRepository.GetById(id);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _autorRepository.Delete(id);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }

        public async Task<Autor?> Update(int id, Autor autor)
        {
            try
            {
                return await _autorRepository.Update(id, autor);
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
