using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Data;
using APIDOJO.Interfaces.Repositories;
using APIDOJO.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDOJO.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AppDbContext _context;

        public LivroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Livro>> GetAll()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task<Livro?> GetById(int id)
        {
            return await _context.Livros.FindAsync(id);
        }

        public async Task<Livro> Add(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
            return livro;
        }

        public async Task<Livro> Update(int id, Livro livro)
        {
            var existingLivro = await _context.Livros.FindAsync(id);
            if (existingLivro == null)
            {
                throw new KeyNotFoundException($"Livro com Id {id} não encontrado.");
            }

            existingLivro.Titulo = livro.Titulo;
            existingLivro.Autor = livro.Autor;

            _context.Livros.Update(existingLivro);
            await _context.SaveChangesAsync();
            return existingLivro;
        }

        public async Task Delete(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                throw new KeyNotFoundException($"Livro com Id {id} não encontrado.");
            }

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }
    }
}
