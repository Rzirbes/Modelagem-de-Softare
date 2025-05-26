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
    public class TutorRepository : ITutorRepository
    {
        private readonly AppDbContext _context;

        public TutorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tutor>> GetAll()
        {
            return await _context.Tutores.ToListAsync();
        }

        public async Task<Tutor?> GetById(int id)
        {
            return await _context.Tutores.FindAsync(id);
        }

        public async Task<Tutor> Add(Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            await _context.SaveChangesAsync();
            return tutor;
        }

        public async Task<Tutor> Update(int id, Tutor tutor)
        {
            var existingTutor = await _context.Tutores.FindAsync(id);
            if (existingTutor == null)
            {
                throw new KeyNotFoundException($"Tutor com Id {id} não encontrado.");
            }

            existingTutor.Name = tutor.Name;
            existingTutor.Email = tutor.Email;

            _context.Tutores.Update(existingTutor);
            await _context.SaveChangesAsync();
            return existingTutor;
        }

        public async Task Delete(int id)
        {
            var tutor = await _context.Tutores.FindAsync(id);
            if (tutor == null)
            {
                throw new KeyNotFoundException($"Tutor com Id {id} não encontrado.");
            }

            _context.Tutores.Remove(tutor);
            await _context.SaveChangesAsync();
        }
    }
}