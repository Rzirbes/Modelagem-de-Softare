using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDOJO.Models
{
    public class Livro
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public int IdAutor { get; set; }
        
        public Autor? Autor { get; set; }
        
        
    }
}