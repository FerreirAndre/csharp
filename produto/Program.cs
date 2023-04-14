using System;
using System.Globalization;

namespace produto
{
  class Program
  {
    static void Main()
    {
      Console.Write("digite o nome do produto: ");
      var nome = Console.ReadLine();
      Console.Write("digite o preco do produto: ");
      var preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("digite a quantidade de produtos: ");
      var quantidade = int.Parse(Console.ReadLine());

      var produto = new Produto(nome, preco, quantidade);
      Console.WriteLine(produto);

      Console.WriteLine("faça uma entrada de quantidades deste produto: ");
      quantidade = int.Parse(Console.ReadLine());
      produto.AdicionarProdutos(quantidade);
      Console.WriteLine(produto);

      Console.WriteLine("faça uma saída de quantidades deste produto: ");
      quantidade = int.Parse(Console.ReadLine());
      produto.RemoverProduto(quantidade);
      Console.WriteLine(produto);
    }
  }
}
