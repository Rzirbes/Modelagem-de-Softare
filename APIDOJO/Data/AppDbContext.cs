using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDOJO.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDOJO.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Livro> Livros => Set<Livro>();
        public DbSet<Autor> Autores => Set<Autor>();
    }
}