namespace Primeiros_Exercicios
{
    public class Exercicio1
    {
        public static void MostrarMaisVelho()
        {
            Console.Write($"Digite o nome da primeira pessoa: ");
            String nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            var pessoa1 = new Pessoa(idade, nome);

            Console.Write($"Digite o nome da segunda pessoa: ");
            nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            idade = int.Parse(Console.ReadLine());
            var pessoa2 = new Pessoa(idade, nome);
            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa1.nome}");
            }
            else if (pessoa2.idade > pessoa1.idade)
            {
                Console.WriteLine($"A pessao mais velha é {pessoa1.nome}");
            }
            else
            {
                Console.WriteLine("as duas pessoas tem a mesma idade.");
            }
            Console.WriteLine();
        }
        public class Pessoa
        {
            public int idade { get; set; }
            public String nome { get; set; }
            public Pessoa(int idade, string nome)
            {
                this.idade = idade;
                this.nome = nome;
            }
        }
    }
}