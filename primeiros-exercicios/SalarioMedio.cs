using System;
namespace Primeiros_Exercicios
{
    public class Exercicio2
    {
        public static void SalarioMedio()
        {
            Console.Write("Digite o nome do primeiro funcionario: ");
            var nome = Console.ReadLine();
            Console.Write("Digite o salario do primeiro funcionario: ");
            var salario = decimal.Parse(Console.ReadLine());
            var funcionario1 = new Funcionario(nome, salario);
            Console.Write("Digite o nome do segundo funcionario: ");
            nome = Console.ReadLine();
            Console.Write("Digite o salario do segundo funcionario: ");
            salario = decimal.Parse(Console.ReadLine());
            var funcionario2 = new Funcionario(nome, salario);
            decimal mediaSalario = (funcionario1.Salario + funcionario2.Salario) / 2;
            Console.WriteLine($"A media de salário dos funcionarios é: {mediaSalario.ToString("C")}");
            Console.WriteLine();
        }
    }
    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome,decimal salario){
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}