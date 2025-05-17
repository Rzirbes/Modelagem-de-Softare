using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class CarrinhoDeCompras
    {
        public int NumCarrinho { get; set; }
        public int NumProduto { get; set; }
        public int Quantidade { get; set; }
        public int DataAdd { get; set; }

        public void AddItem()
        {
            Console.WriteLine("Item adicionado ao carrinho");
        }

        public void AtualizaQuant()
        {
            Console.WriteLine("Quantidade atualizada no carrinho");
        }

        public void VerDetalheCarrinho()
        {
            Console.WriteLine("Visualizando detalhes do carrinho");
        }

        public void ProssegCompra()
        {
            Console.WriteLine("Prosseguindo com a compra");
        }
    }
}