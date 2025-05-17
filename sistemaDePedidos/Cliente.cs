using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class Cliente : Usuario
    {
        public string? NomeCliente { get; set; }
        public string? Endereço { get; set; }
        public string? InfoCartaoCredito { get; set; }
        public string? InfoEnvio { get; set; }
        public decimal SaldoConta { get; set; }


        public void Cadastro()
        {
            Console.WriteLine("Cadastrando");
        }
        public void Login()
        {
            Console.WriteLine("Logando");
        }





    }
}