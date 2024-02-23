

class FormaDePagamento
{
    public int Forma_pagamento { get; set; }

    public static string Pagamento(int Forma_pagamento)
    {
        switch (Forma_pagamento)
        {
            case 1:
                return "Insira sua senha.\n" + "283249-999" + CartaoCredito.Cartao();
            case 2:
                return "Insira sua senha.\n" + "3233" + CartaoDebito.Cartao();
            case 3:
                return "Pague seu dinheiro. \n" + Dinheiro.Valor();
            case 4:
                return "Insira nosso CPF.\n" + Pix.CPF();
            default:
                return "Forma de pagamento invalida.";
        }
    }

    public static string Cartao()
    {
        return "Método de pagamento com cartão.";
    }

public class Dinheiro {
    public static string Valor(double totalCompra)
{
    return $"Pague-nos o valor de {totalCompra:C}";
}

        internal static string Valor()
        {
            throw new NotImplementedException();
        }
    }
    public class Pix
    {
        public static string CPF()
        {
            return "Insira nosso CPF no seu aplicativo - 12333-21568";
        }
    }
}

class CartaoCredito
{
    public static string Cartao()
    {
        return "Método de pagamento com cartão de crédito.";
    }
}

class CartaoDebito
{
    public static string Cartao()
    {
        return "Método de pagamento com cartão de débito.";
    }
}


