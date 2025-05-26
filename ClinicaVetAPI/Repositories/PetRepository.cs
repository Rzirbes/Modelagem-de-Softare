using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaVetAPI.Data;
using ClinicaVetAPI.Interfaces.Repositories;
using ClinicaVetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVetAPI.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly AppDbContext _context;

        public PetRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pet>> GetAll()
        {
            return await _context.Pets.ToListAsync();
        }

        public async Task<Pet?> GetById(int id)
        {
            return await _context.Pets.FindAsync(id);
        }

        public async Task<Pet> Add(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return pet;
        }

        public async Task<Pet> Update(int id, Pet pet)
        {
            var existingPet = await _context.Pets.FindAsync(id);
            if (existingPet == null)
            {
                throw new KeyNotFoundException($"Pet com Id {id} não encontrado.");
            }

            existingPet.Name = pet.Name;
            existingPet.Raca = pet.Raca;
            existingPet.Especie = pet.Especie;

            _context.Pets.Update(existingPet);
            await _context.SaveChangesAsync();
            return existingPet;
        }

        public async Task Delete(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                throw new KeyNotFoundException($"Pet com Id {id} não encontrado.");
            }

            _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();
        }
    }
}