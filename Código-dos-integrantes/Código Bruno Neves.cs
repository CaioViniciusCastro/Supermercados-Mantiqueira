using System;
using System.Collections.Generic;

enum TipoAvaliacao : Program
{
    Boa
    Ruim
}

class Supermercado
{
    public string Nome { get; set; }
    public List<TipoAvaliacao> Avaliacoes { get; set; } = new List<TipoAvaliacao>();

    public void AdicionarAvaliacao(TipoAvaliacao avaliacao)
    {
        Avaliacoes.Add(avaliacao);
    }

    public double CalcularPercentualAvaliacaoBoa()
    {
        if (Avaliacoes.Count == 0)
            return 0;

        int boas = Avaliacoes.Count(avaliacao => avaliacao == TipoAvaliacao.Boa);
        return (double)boas / Avaliacoes.Count * 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
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
