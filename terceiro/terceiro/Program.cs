using System;

namespace terceiro {
    class Program {
        static void Main(string[] args) {
            char escolha;
            do {
                menu();
                int exercicioEscolhido = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (exercicioEscolhido) {
                    
                    case 1:
                        Console.Write("Digite um numero para saber se ele é negativo: ");
                        int numeroEx1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Ex1(numeroEx1));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 2:
                        Console.Write("digite um numero para saber se ele é par ou impar: ");
                        int numeroEx2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Ex2(numeroEx2));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 3:
                        Console.Write("digite dois numero para saber se eles sao multiplos: ");
                        string[] vetEx3 = Console.ReadLine().Split();
                        int numero1Ex3 = int.Parse(vetEx3[0]);
                        int numero2Ex3 = int.Parse(vetEx3[1]);
                        Console.WriteLine(Ex3(numero1Ex3, numero2Ex3));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 4:
                        Console.Write("digite o horario inicial e o final do jogo: ");
                        string[] vetEx4 = Console.ReadLine().Split();
                        int numero1Ex4 = int.Parse(vetEx4[0]);
                        int numero2Ex4 = int.Parse(vetEx4[1]);
                        Ex4(numero1Ex4, numero2Ex4);
                        Console.ReadKey();
                        Console.Clear(); break;
                    
                    case 5:
                        Console.WriteLine("1 - hot dog - R$4.00" +
                            "\n2 - x salada - R$4.50" +
                            "\n3 - x bacon - R$5.00" +
                            "\n4 - torrada simples - R$2.00" +
                            "\n5 - refrigerante - R$1.50");
                        string[] vetEx5 = Console.ReadLine().Split();
                        int op1 = int.Parse(vetEx5[0]);
                        int op2 = int.Parse(vetEx5[1]);
                        Ex5(op1, op2);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 6:
                        Console.Write("digite um numero (entre 0 e 100) para saber o intervalo dele: ");
                        double numEx6 = double.Parse(Console.ReadLine());
                        Ex6(numEx6);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 7:
                        Console.WriteLine("digite o eixo x e o eixo y para saber qual quadrante o ponto dessa coordenada se encontra");
                        string[] vetEx7 = Console.ReadLine().Split();
                        double x = double.Parse(vetEx7[0]);
                        double y = double.Parse(vetEx7[1]);
                        Ex7(x, y);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 8:
                        Console.Write("digite o salario para saber o valor do imposto de renda: ");
                        double salario = double.Parse(Console.ReadLine());
                        Console.WriteLine(Ex8(salario));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    default:
                        Console.WriteLine("exercicio inexistente.");
                        break;
                }
                Console.WriteLine("deseja escolher novamente ou deseja sair?" +
                    "\n[c]continuar    [s] sair");
                escolha = char.Parse(Console.ReadLine());
            } while (escolha != 's');
        }
        static void menu() {
            Console.WriteLine("digite o numero do exercicio que deseja fazer" +
                "\n1 - negativo ou positivo" +
                "\n2 - par ou ímpar" +
                "\n3 - multiplos" +
                "\n4 - duração do jogo" +
                "\n5 - menu de lanchonete" +
                "\n6 - intervalo" +
                "\n7 - plano cartesiano" +
                "\n8 - salario e imposto de renda");
        }
        static string Ex1(int numero) {
            if (numero >= 0)
                return "positivo";
            else
                return "negativo";
        }
        static string Ex2(int numero) {
            if (numero % 2 == 0)
                return "par";
            else
                return "impar";
        }
        static string Ex3(int num1, int num2) {
            if (num1 % num2 == 0 || num2 % num1 == 0)
                return "sao multiplos";
            else
                return "nao sao multiplos";
        }
        static void Ex4(int num1, int num2) {
            int horas;
            if (num1 == num2) {
                horas = 24;
            } else if (num1 < num2) {
                horas = num2 - num1;
            } else {
                horas = 24 - num1 + num2;
            }
            Console.WriteLine($"o jogo durou {horas} horas");
        }
        static void Ex5(int op1, int op2) {
            double[] vetorValores = { 4, 4.5, 5, 2, 1.5 };
            if (op1 < 1 || op1 > 5) {
                Console.WriteLine("numero de item invalido.");
            } else {
                double valor = vetorValores[op1 - 1] * op2;
                Console.WriteLine($"total: R${valor}");
            }
        }
        static void Ex6(double valor) {
            if (valor >= 0 && valor <= 25)
                Console.WriteLine("intervalo: [0, 25]");
            else if (valor > 25 && valor <= 50)
                Console.WriteLine("intervalo: [25, 50]");
            else if (valor > 50 && valor <= 75)
                Console.WriteLine("intervalo: [50, 75]");
            else if (valor > 75 && valor <= 100)
                Console.WriteLine("intervalo: [75, 100]");
            else
                Console.WriteLine("valor fora do intervalo.");
        }
        static void Ex7(double x, double y) {
            if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && x < 0)
                Console.WriteLine("Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
            else if (x == 0 && y == 0)
                Console.WriteLine("origem");
            else if (x == 0)
                Console.WriteLine("eixo Y");
            else
                Console.WriteLine("eixo X");
        }
        static string Ex8(double salario) {
            double imposto;
            if (salario <= 2000)
                return "Isento";
            else if (salario <= 3000) {
                imposto = (salario - 2000) * 0.08;
                return $"o valor do imposto de renda é de R${imposto.ToString("F2")}";
            } else if (salario <= 4500) {
                imposto = 1000 * 0.08;
                imposto += (salario - 3000) * 0.18;
                return $"o valor do imposto de renda é de R${imposto.ToString("F2")}";
            } else {
                imposto = 1000 * 0.08;
                imposto += 1500 * 0.18;
                imposto += (salario - 4500) * 0.28;
                return $"o valor do imposto de renda é de R${imposto.ToString("F2")}";
            }
        }
    }
}
