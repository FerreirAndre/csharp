using System;

namespace segundo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("entre com o preço do produto");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("entre com seu ultimo nome, idade e altura");
            string[] vet = Console.ReadLine().Split(" ");
            string nome1 = vet[0];
            int idade = int.Parse(vet[1]);
            decimal altura = decimal.Parse(vet[2]);
            Console.WriteLine($"{nome1}, {idade}, {altura}");
        }
    }
}
