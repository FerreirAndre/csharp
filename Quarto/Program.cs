﻿using System;
using System.Globalization;

namespace Quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite os 3 numeros");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("o maior numero é: " +  Maior(num1, num2, num3));
            Console.ReadKey();
        }

        static int Maior(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
                return num1;
            else if (num2 > num3)
                return num2;
            else
                return num3;
        }
    }
}
