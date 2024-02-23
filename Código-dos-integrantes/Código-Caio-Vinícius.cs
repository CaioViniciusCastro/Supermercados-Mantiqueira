class Confirmacao : Program
{
    static void Main(string[] args)
    {
        FormasPagamento a = new FormasPagamento();
        Console.WriteLine("ABA DE PAGAMENTOS:");
        Console.WriteLine($"Valor total de sua compra: {listaDeProdutos[escolhaProduto].Preco * quantidadeCompra}$"); //inserir variavel contendo o dinheiro total
        Console.WriteLine();
        Console.WriteLine("Como o senhor deseja pagar? \n(1-Cartão de crédito) \n(2-Cartão de débito)\n(3-Dinheiro)\n(4-Pix)");
        a.Forma_pagamento = int.Parse(Console.ReadLine());
        FormasPagamento.Pagamento(a.Forma_pagamento);
        Console.ReadLine();
    }
}



public class FormasPagamento
{
    public int Forma_pagamento { get; set; }

    
    
    public static string Pagamento(int Forma_pagamento)
    {
        switch (Forma_pagamento) { 

            case 1:
                return "Insira sua senha.\n" +
                    "283249-999" +
                CartaoCredito.Cartao();
 
            case 2:
                return"Insira sua senha.\n" +
                    "3233" +
                CartaoDebito.Cartao();
                

            case 3:
                return "Pague seu dinheiro. \n" + 
                Dinheiro.Preco();
                

            case 4:
                return "Insira nosso CPF.\n" +
                Pix.CPF();
         

            default:
                return "Forma de pagamento invalida.";         
        }
    }
}



using System;

public class CartaoCredito
{

    private static Random random = new Random();


    public static string Cartao()
    {
        int Chance_erro = random.Next(10);
        if (Chance_erro == 1)
        {
            return "Você não tem créditos o suficiente.";
        }
        else
        {
            return "Pagamento aprovado.";
        }
    }
}



using System;

public class CartaoDebito
{

    private static Random random = new Random();


        public static string Cartao()
        {

            int Chance_erro = random.Next(10);
            if (Chance_erro == 1)
            {
                return "Você não tem débito o suficiente.";
            }
            else
            {
                return "Pagamento aprovado.";
            }

        }    
}



public class Dinheiro
{


    public static string Preco(){
        return $"Pague-nos o valor de {XXX}$"; //inserir variavel do dinheiro total;
        }
}



public class Pix
{

    public static string CPF(){
        return "Insira nosso cpf no seu aplicativo - 12333-21568";
    }
}
