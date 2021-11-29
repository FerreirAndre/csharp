using System;

namespace Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var p = new Program();
            p.Ex1();
            p.Ex2();
            p.Ex3();
        }

        public void Ex1()
        {
            int senha;
            Console.Write("digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("senha invalida");
                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Senha correta");
        }
        public void Ex2()
        {
            int x, y;
            Console.Write("Digite as coordenadas: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    System.Console.WriteLine("Primeiro quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    System.Console.WriteLine("Segundo quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    System.Console.WriteLine("Terceiro quadrante");
                }
                else
                {
                    System.Console.WriteLine("Quarto Quadrante");
                }
                Console.Write("Digite as coordenadas: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
        public void Ex3()
        {
            int opcao, alcool = 0, gasolina = 0, diesel = 0;
            System.Console.WriteLine("Digite os combustiveis de preferencia\n1-alcool\n2-gasolina\n3-diesel");
            System.Console.Write("digite a opcao: ");
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 4)
            {
                switch (opcao)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    default:
                        System.Console.WriteLine("opcao invalida");
                        break;
                }
                System.Console.Write("Digite o combustivel: ");
                opcao = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine($"muito obrigado!\nalcool = {alcool}\ngasolina = {gasolina}\ndiesel = {diesel}");

        }
    }
}