using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var p = new Program();
            int opcao;
            do
            {
                Console.Write("digite qual exercicio deseja fazer: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        p.Ex1();
                        break;
                    case 2:
                        p.Ex2();
                        break;
                    case 3:
                        p.Ex3();
                        break;
                    case 4:
                        p.Ex4();
                        break;
                    case 5:
                        p.Ex5();
                        break;
                    case 6:
                        p.Ex6();
                        break;
                    case 7:
                        p.Ex7();
                        break;
                    default:
                        break;
                }
            } while (opcao != 0);
        }
        public void Ex1()
        {
            Console.Write("Digite um numero para saber os impares: ");

            var valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Ex2()
        {
            Console.Write("Digite a qtd de numeros a serem lidos: ");
            var qtd = int.Parse(Console.ReadLine());
            int valor, dentro = 0, fora = 0;
            for (int i = 0; i < qtd; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                    dentro++;
                else
                    fora++;
            }
            Console.WriteLine($"{dentro} in\n{fora} out.");
        }
        public void Ex3()
        {
            Console.Write("Digite a quantidade de testes: ");
            var qtd = int.Parse(Console.ReadLine());
            double num1, num2, num3, media;
            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"valor {i + 1}:");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                num3 = double.Parse(Console.ReadLine());
                media = num1 * 0.2 + num2 * 0.3 + num3 * 0.5;
                Console.WriteLine(media.ToString("F1"));
            }
        }
        public void Ex4()
        {
            Console.Write("digite a quantidade de contas: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Digite dois numeros para fazer a divisao: ");
                var s = Console.ReadLine().Split(' ');
                double num1 = double.Parse(s[0]);
                double num2 = double.Parse(s[1]);
                if (num2 == 0.0)
                {
                    Console.WriteLine("operacao impossivel.");
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }
            }
        }
        public void Ex5()
        {
            Console.Write("digite um numero para saber seu fatorial: ");
            int valor = int.Parse(Console.ReadLine());
            int resultado = 1;
            if (valor != 0)
            {
                for (int i = valor; i > 0; i--)
                {
                    resultado *= i;
                }
            }
            Console.WriteLine(resultado);
        }
        public void Ex6()
        {
            Console.Write("digite um numero para calcular seus divisores: ");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Ex7()
        {
            Console.Write("digite um numero: ");
            int valor = int.Parse(Console.ReadLine());
            int[,] matriz = new int[valor, 3];

            for (int i = 1; i <= valor; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        matriz[i - 1, j] = i;
                    }
                    else if (j == 1)
                    {
                        matriz[i - 1, j] = (int)Math.Pow(i, 2);
                    }
                    else
                    {
                        matriz[i - 1, j] = (int)Math.Pow(i, 3);
                    }
                    Console.Write($"{matriz[i - 1, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}