using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVetAPI.Interfaces;
using ClinicaVetAPI.Interfaces.Repositories;
using ClinicaVetAPI.Models;

namespace ClinicaVetAPI.Services
{
    public class PetService : IBaseService<Pet>
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<Pet> Add(Pet pet)
        {
            return await _petRepository.Add(pet);
        }

        public async Task<List<Pet>> GetAll()
        {
            var pets = await _petRepository.GetAll();
            return pets.ToList();
        }

        public async Task<Pet?> GetById(int id)
        {
            return await _petRepository.GetById(id);
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _petRepository.Delete(id);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }

        public async Task<Pet?> Update(int id, Pet pet)
        {
            try
            {
                return await _petRepository.Update(id, pet);
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}
