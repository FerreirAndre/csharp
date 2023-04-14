using System;

namespace exercicio
{
  class Aluno
  {
    public string nome { get; }
    public decimal nota1 { get; }
    public decimal nota2 { get; }
    public decimal nota3 { get; }

    public Aluno(string nome, decimal nota1, decimal nota2, decimal nota3)
    {
      this.nome = nome;
      this.nota1 = nota1;
      this.nota2 = nota2;
      this.nota3 = nota3;
    }
    public decimal NotaFinal()
    {
      return nota1 + nota2 + nota3;
    }
    public string Aprovado()
    {
      return NotaFinal() >= 60.00m ? "Aprovado" : $"Reprovado, faltaram {60.00m - NotaFinal()} pontos.";
    }
    public override string ToString()
    {
      string retorno = $"Nome: {nome}\n" +
      $"Nota Final: {NotaFinal()}\n" +
      $"{Aprovado()}";
      return retorno;
    }
  }
}