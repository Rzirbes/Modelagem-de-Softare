using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class DetalhesPedido
    {
        public int NumPedido { get; set; }
        public int NumProduto { get; set; }
        public string? NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public float CustoUnidade { get; set; }
        public float SubTotal { get; set; }

        public float CalcularPreco()
        {
            SubTotal = Quantidade * CustoUnidade;
            return SubTotal;
        }
    }
}