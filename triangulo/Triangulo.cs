using System;

namespace triangulo
{
  class Triangulo
  {
    public double A { get; }
    public double B { get; }
    public double C { get; }
    public Triangulo(double A, double B, double C)
    {
      this.A = A;
      this.B = B;
      this.C = C;
    }
    public double Area()
    {
      double p = (A + B + C) / 2.0;
      double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
      return area;
    }
  }
}