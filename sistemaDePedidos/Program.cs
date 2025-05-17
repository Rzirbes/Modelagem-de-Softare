
using sistemaDePedidos;

// Instanciando um cliente
Cliente cliente = new Cliente
{
    NomeCliente = "João Silva",
    Endereço = "Rua das Flores, 123",
    InfoCartaoCredito = "1234-5678-9012-3456",
    InfoEnvio = "Padrão",
    SaldoConta = 150.75M
};
cliente.Cadastro();
cliente.Login();

// Instanciando um carrinho de compras
CarrinhoDeCompras carrinho = new CarrinhoDeCompras
{
    NumCarrinho = 1,
    NumProduto = 101,
    Quantidade = 2,
    DataAdd = 20240512
};
carrinho.AddItem();
carrinho.VerDetalheCarrinho();

// Instanciando um pedido
Pedido pedido = new Pedido
{
    NumPedido = 5001,
    NomeCliente = cliente.NomeCliente,
    DataEnvio = "2024-05-13",
    NumCliente = 1,
    Estado = "Em andamento"
};
pedido.FinalizaPedido();

// Instanciando informações de envio
InformacaoEnvio infoEnvio = new InformacaoEnvio
{
    NumEnvio = 1,
    TipoEnvio = "Sedex",
    CustoEnvio = 20.5f,
    NumRegiaoEnvio = 3
};
infoEnvio.AtualizarInfoEnvio();

// Instanciando detalhes do pedido
DetalhesPedido detalhes = new DetalhesPedido
{
    NumPedido = pedido.NumPedido,
    NumProduto = carrinho.NumProduto,
    NomeProduto = "Camiseta Fitness",
    Quantidade = carrinho.Quantidade,
    CustoUnidade = 50.0f
};

float precoTotal = detalhes.CalcularPreco();
Console.WriteLine($"Subtotal do pedido: R${precoTotal}");