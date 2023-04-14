using System;

namespace produto
{
  class Produto
  {
    public string nome { get; set; }
    public decimal preco { get; set; }
    public int quantidade { get; set; }

    public Produto(string nome, decimal preco, int quantidade)
    {
      this.nome = nome;
      this.preco = preco;
      this.quantidade = quantidade;
    }

    public void AdicionarProdutos(int quantidade)
    {
      this.quantidade += quantidade;
    }

    public void RemoverProduto(int quantidade)
    {
      this.quantidade -= quantidade;
    }

    public decimal ValorTotalEmEstoque()
    {
      return preco * quantidade;
    }

    public override string ToString()
    {
      string retorno = "Dados do produto:\n" +
      $"nome: {this.nome}.\n" +
      $"preço: {this.preco}\n" +
      $"quantidade no estoque: {this.quantidade}\n" +
      $"valor total no estoque: {ValorTotalEmEstoque()}";
      return retorno;
    }
  }
}