using System;
namespace Primeiros_Exercicios
{
    class Program
    {
        public static void Main()
        {
            int resposta;
            do
            {
                Menu();
                resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 0:
                        Console.WriteLine("firmeza.");
                        break;
                    case 1:
                        Exercicio1.MostrarMaisVelho();
                        break;
                    case 2:
                        Exercicio2.SalarioMedio();
                        break;
                    default:
                        Console.WriteLine("esta opção não é valida.");
                        break;
                }
            } while (resposta != 0);
        }
        public static void Menu(){
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("0 - Sair");
        }
    }
}