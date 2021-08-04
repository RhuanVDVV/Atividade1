using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double Preco;
            int Quantidade, QuantidadeA, QuantidadeR;
            Console.WriteLine("Digite o nome do produto: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade em estoque do produto: ");
            Quantidade = int.Parse(Console.ReadLine());
            Produto produto = new Produto(Nome, Preco, Quantidade);
            produto.ValorTotalEmEstoque();
            Console.WriteLine(produto.ToString());
            Console.WriteLine("Digite a quantidade de produtos a ser adicionado ao estoque: ");
            QuantidadeA = int.Parse(Console.ReadLine());
            produto.DadosAtualizados(QuantidadeA);
            produto.ValorTotalEmEstoque();
            Console.WriteLine(produto.ToString());
            Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque: ");
            QuantidadeR = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(QuantidadeR);
            produto.ValorTotalEmEstoque();
            Console.WriteLine(produto.ToString());
            Console.ReadKey();
        }
    }
}
