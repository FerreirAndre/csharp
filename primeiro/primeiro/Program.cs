using System;
using System.Globalization;

namespace primeiro {
    class Program {
        static void Main(string[] args) {

            string produto1 = "computador", produto2 = "mesa de escritório";
            byte idade = 20;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.00, preco2 = 650.50, medida = 53.234567;

            Console.WriteLine($"Proutos:\n" +
                $"{produto1}, cujo preço é ${preco1:F2}\n" +
                $"{produto2}, cujo preço é ${preco2:F2}");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (com 3 casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}
