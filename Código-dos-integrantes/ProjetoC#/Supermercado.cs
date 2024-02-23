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
