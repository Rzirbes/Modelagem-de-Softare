using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class Pedido
    {
        public int NumPedido { get; set; }
        public string? NomeCliente { get; set; }
        public string? DataEnvio { get; set; }
        public int NumCliente { get; set; }
        public string? Estado { get; set; }

        public void FinalizaPedido()
        {
            Console.WriteLine("Pedido finalizado");
        }
    }
}