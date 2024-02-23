using System;
using System.Collections.Generic;
using System.Linq;

class Produto
{
    public string Nome { get; private set; }
    public double Preco { get; private set; }
    public int Quantidade { get; set; }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }
}