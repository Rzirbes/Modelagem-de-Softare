using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class Usuario
    {
        public int NumUsuario { get; set; }
        public int Senha { get; set; }
        public string? EstadoLogin { get; set; }
        public DateTime DataCadastro { get; set; }

        public void verificaLogin()
        {
            Console.WriteLine("Validando Login");
        }

    }
}