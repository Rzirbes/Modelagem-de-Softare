using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDePedidos
{
    public class InformacaoEnvio
    {
        public int NumEnvio { get; set; }
        public string? TipoEnvio { get; set; }
        public float CustoEnvio { get; set; }
        public int NumRegiaoEnvio { get; set; }

        public void AtualizarInfoEnvio()
        {
            Console.WriteLine("Informações de envio atualizadas");
        }
    }
}