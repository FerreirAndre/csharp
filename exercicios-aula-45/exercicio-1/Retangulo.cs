using System;

namespace exercicio
{
  class Retangulo
  {
    public double altura { get; set; }
    public double largura { get; set; }

    public Retangulo(double altura, double largura)
    {
      this.altura = altura;
      this.largura = largura;
    }
    public double area()
    {
      double area = altura * largura;
      return area;
    }
    public double perimetro()
    {
      double perimetro = 2 * altura + 2 * largura;
      return perimetro;
    }
    public double diagonal(){
      double diagonal = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
      return diagonal;
    }
    public override string ToString()
    {
      var retorno = $"Area: {area()}\n" +
      $"Perimetro: {perimetro()}\n" +
      $"Diagonal: {diagonal()}";
      return retorno;
    }
  }
}