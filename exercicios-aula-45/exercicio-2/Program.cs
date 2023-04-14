using System;
using System.Globalization;
namespace exercicio // Note: actual namespace depends on the project name.
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Digite as informações do funcionário");
      Console.Write("Nome: ");
      var nome = Console.ReadLine();
      Console.Write("Salario bruto: ");
      var salarioBruto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Imposto: ");
      var imposto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      var funcionario = new Funcionario(nome, salarioBruto, imposto);
      Console.WriteLine(funcionario);
      Console.Write("digite a porcentagem para aumentar o salário: ");
      var aumento = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine();
      funcionario.AumentarSalario(aumento);
      Console.WriteLine("Dados atualizados\n" + funcionario);
    }
  }
}