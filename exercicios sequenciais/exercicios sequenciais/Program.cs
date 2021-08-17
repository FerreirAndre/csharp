using System;

namespace exercicios_sequenciais {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Exercicio 1");
            int varSoma1, varSoma2;
            Console.WriteLine("digite os dois numeros");
            string[] vetSoma = Console.ReadLine().Split(" ");
            varSoma1 = int.Parse(vetSoma[0]);
            varSoma2 = int.Parse(vetSoma[1]);
            Console.WriteLine($"soma: {Soma(varSoma1, varSoma2)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area:{Area(raio).ToString("4F")}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Exercicio 3");
            Console.WriteLine("digite quatro valores: ");
            int varDif1, varDif2, varDif3, varDif4;
            string[] vetDif = Console.ReadLine().Split(" ");
            varDif1 = int.Parse(vetDif[0]);
            varDif2 = int.Parse(vetDif[1]);
            varDif3 = int.Parse(vetDif[2]);
            varDif4 = int.Parse(vetDif[3]);
            Console.WriteLine($"Diferenca: {Diferenca(varDif1, varDif2, varDif3, varDif4)}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Digite o numero do funcionario, horas trabalhadas e salario por hora");
            string[] vetSalario = Console.ReadLine().Split(" ");
            int numFuncionario = int.Parse(vetSalario[0]);
            int horasTrab = int.Parse(vetSalario[1]);
            decimal salarioHora = decimal.Parse(vetSalario[2]);
            SalarioHoras(numFuncionario, horasTrab, salarioHora);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Exercicio 5");
            Console.Write("Digite o numero do produto, sua quantidade e seu valor unitario: ");
            string[] vetProduto1 = Console.ReadLine().Split(" ");
            int produto1num = int.Parse(vetProduto1[0]);
            int produto1qtd = int.Parse(vetProduto1[1]);
            decimal produto1valor = decimal.Parse(vetProduto1[2]);
            decimal valorTotal= ValorProduto(produto1qtd,produto1valor);

            Console.Write("Digite o numero do produto, sua quantidade e seu valor unitario: ");
            string[] vetProduto2 = Console.ReadLine().Split(" ");
            int produto2num = int.Parse(vetProduto2[0]);
            int produto2qtd = int.Parse(vetProduto2[1]);
            decimal produto2valor = decimal.Parse(vetProduto2[2]);
            valorTotal += ValorProduto(produto2qtd, produto2valor);
            Console.WriteLine($"{valorTotal}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Exercicio 6");
            Console.Write("Digite o valor de A, B e C: ");
            string[] vetEx6 = Console.ReadLine().Split(" ");
            double a = double.Parse(vetEx6[0]);
            double b = double.Parse(vetEx6[1]);
            double c = double.Parse(vetEx6[2]);
            Exercicio6(a, b, c);
        }

        static int Soma(int a, int b) {
            return a + b;
        }

        static double Area(double raio) {
            return Math.Pow(raio, 2) * Math.PI;
        }

        static int Diferenca(int a, int b, int c, int d) {
            return (a * b - c * d);
        }

        static void SalarioHoras(int numeroFuncionario, int horasTrabalhadas, decimal salarioHorario) {
            decimal salario = horasTrabalhadas * salarioHorario;
            string s = $"{numeroFuncionario}, salario: R${salario}";
            Console.WriteLine(s);
        }

        static decimal ValorProduto(int qtd, decimal valor) {
            return qtd * valor;
        }

        static void Exercicio6(double a, double b, double c) {
            Console.WriteLine($"area do triangulo: {(a*c/2).ToString("3F")}");
            Console.WriteLine($"area do circulo: {(Math.Pow(c, 2) * Math.PI).ToString("3F")}");
            Console.WriteLine($"area do trapezio: {((a + b) * c / 2).ToString("3F")}");
            Console.WriteLine($"area do quadrado: {(Math.Pow(b,2)).ToString("3F")}");
            Console.WriteLine($"area do retangulo: {(a*b).ToString("3F")}");
        }
    }
}