using System;
using System.Globalization;
namespace triangulo
{
  class Program
  {
    static void Main(){
      Console.Write("digite o lado A: ");
      double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("digite o lado B: ");
      double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("digite o lado C: ");
      double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      var triangulo = new Triangulo(a, b, c);

      Console.WriteLine(triangulo.Area());
    }
  }
}