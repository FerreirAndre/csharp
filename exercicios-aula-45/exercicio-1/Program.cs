using System;
using System.Globalization;

namespace exercicio
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Digite a altura e a largura do retângulo: ");
      var altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      var largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
      var retangulo = new Retangulo(altura, largura);
      Console.WriteLine(retangulo);
    }
  }
}