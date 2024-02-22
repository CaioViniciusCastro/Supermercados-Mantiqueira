namespace ProjetoC_ {
class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listaDeProdutos = InicializarProdutos();
            Loja loja = new Loja(listaDeProdutos);

            loja.MostrarProdutos();
            loja.ProcessarCompra();
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
    }
}