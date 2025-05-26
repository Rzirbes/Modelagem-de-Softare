using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Data;
using APIDOJO.Interfaces.Repositories;
using APIDOJO.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDOJO.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly AppDbContext _context;

        public AutorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Autor>> GetAll()
        {
            return await _context.Autores.ToListAsync();
        }

        public async Task<Autor?> GetById(int id)
        {
            return await _context.Autores.FindAsync(id);
        }

        public async Task<Autor> Add(Autor autor)
        {
            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();
            return autor;
        }

        public async Task<Autor> Update(int id, Autor autor)
        {
            var existingAutor = await _context.Autores.FindAsync(id);
            if (existingAutor == null)
            {
                throw new KeyNotFoundException($"Autor com Id {id} não encontrado.");
            }

            existingAutor.Name = autor.Name;
            existingAutor.Email = autor.Email;

            _context.Autores.Update(existingAutor);
            await _context.SaveChangesAsync();
            return existingAutor;
        }

        public async Task Delete(int id)
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor == null)
            {
                throw new KeyNotFoundException($"Autor com Id {id} não encontrado.");
            }

            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();
        }
    }
}