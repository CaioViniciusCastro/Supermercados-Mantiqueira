using ProjetoC_;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> listaDeProdutos = InicializarProdutos();
        Loja loja = new Loja(listaDeProdutos);

        loja.MostrarProdutos();
        loja.ProcessarCompra();


        Console.WriteLine("ABA DE PAGAMENTOS:");
        Console.WriteLine();
        Console.WriteLine("Como o senhor deseja pagar? \n(1-Cartão de crédito) \n(2-Cartão de débito)\n(3-Dinheiro)\n(4-Pix)");
        FormaDePagamento a = new FormaDePagamento();
        a.Forma_pagamento = int.Parse(Console.ReadLine());
        FormaDePagamento.Pagamento(a.Forma_pagamento);

        Supermercado supermercado = new Supermercado();
        supermercado.Nome = "Meu Supermercado";

        Console.WriteLine($"Por favor, avalie o supermercado {supermercado.Nome} (boa ou ruim):");
        TipoAvaliacao avaliacao = LerAvaliacao();

        supermercado.AdicionarAvaliacao(avaliacao);

        if (avaliacao == TipoAvaliacao.Ruim)
        {
            Console.WriteLine("Lamentamos pela sua experiência. Trabalharemos para melhorar. Obrigado por nos informar.");
        }
        else
        {
            Console.WriteLine("Agradecemos pela sua preferência! Volte sempre ao nosso supermercado.");
        }

        Console.ReadLine();
    }

    static List<Produto> InicializarProdutos()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto("Arroz", 19.99, 20),
            new Produto("Açúcar", 15.99, 25),
            new Produto("Feijão", 12.99, 21),
            new Produto("Café", 10.99, 18),
            new Produto("Macarrão", 5.99, 17)
        };
        return produtos;
    }

    static double CalcularValorTotal(List<Produto> produtos)
    {
        double valorTotal = 0;
        foreach (var produto in produtos)
        {
            valorTotal += produto.Preco * produto.Quantidade;
        }
        return valorTotal;
    }

    static TipoAvaliacao LerAvaliacao()
    {
        while (true)
        {
            string entrada = Console.ReadLine().ToLower();
            if (entrada == "boa")
            {
                return TipoAvaliacao.Boa;
            }
            else if (entrada == "ruim")
            {
                return TipoAvaliacao.Ruim;
            }
            else
            {
                Console.WriteLine("Por favor, insira 'boa' ou 'ruim':");
            }
        }
    }
}

enum TipoAvaliacao
{
    Boa,
    Ruim
}