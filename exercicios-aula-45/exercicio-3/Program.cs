using System;

namespace exercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite o nome do aluno:");
      var nome = Console.ReadLine();
      Console.WriteLine("Digite as três notas do aluno:");
      decimal[] notas = new decimal[3];
      for (int i = 0; i < 3; i++)
      {
        notas[i] = decimal.Parse(Console.ReadLine());
      }
      var aluno = new Aluno(nome, notas[0], notas[1], notas[2]);
      Console.WriteLine(aluno);
    }
  }
}