namespace ProjetoC_
{
    class Loja
{
    private List<Produto> listaDeProdutos;

    public Loja(List<Produto> produtos)
    {
        listaDeProdutos = produtos;
    }

    public void MostrarProdutos()
    {
        Console.WriteLine("Lista de Produtos:");
        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine($"Produto: {produto.Nome} - Preço: R${produto.Preco} - Quantidade: {produto.Quantidade}");
        }
    }

        public void ProcessarCompra()
        {
            string resposta;
            do
            {
                Console.WriteLine("\nDeseja comprar algum produto? (Sim/Não)");
                resposta = Console.ReadLine();

                if (resposta == "Sim")
                {
                    MostrarProdutos();

                    Console.WriteLine("\nDigite o número do produto que deseja comprar:");
                    int escolhaProduto = int.Parse(Console.ReadLine()) - 1;

                    if (escolhaProduto >= 0 && escolhaProduto < listaDeProdutos.Count)
                    {
                        Console.WriteLine("Digite a quantidade desejada:");
                        int quantidadeCompra = int.Parse(Console.ReadLine());

                        if (quantidadeCompra <= listaDeProdutos[escolhaProduto].Quantidade)
                        {
                            listaDeProdutos[escolhaProduto].Quantidade -= quantidadeCompra;
                           double totalCompra = listaDeProdutos[escolhaProduto].Preco * quantidadeCompra;
                            Console.WriteLine($"Compra realizada com sucesso! Total: R${totalCompra}");
                            Console.WriteLine($"Estoque atual de {listaDeProdutos[escolhaProduto].Nome}: {listaDeProdutos[escolhaProduto].Quantidade}");
                        }
                        else
                        {
                            Console.WriteLine("Desculpe, não há estoque suficiente para essa quantidade.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                    }
                }
                else if (resposta.ToLower() == "Não")
                {
                    Console.WriteLine("Obrigado por visitar nossa loja!");
                }
                else
                {
                    Console.WriteLine("Resposta inválida.");
                }
            } while (resposta.ToLower() == "Sim");
        }
    }
}
