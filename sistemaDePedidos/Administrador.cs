using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class Administrador : Usuario
    {
        public string? NomeAdm { get; set; }
        public string? Email { get; set; }
        public bool AtualizarCatalogo()
        {
            Console.WriteLine("Atualiza Catalogo");
            return true;
        }





    }
}