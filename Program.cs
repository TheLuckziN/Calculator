using System;
using System.Runtime.Intrinsics;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();

            Console.WriteLine("Seja bem vindo a calculadora do Luckzin!");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Divisão");
            Console.WriteLine("[4] - Multiplicação");
            Console.WriteLine("[5] - Sair");
            Console.WriteLine("----------------------------------------");
            Console.Write("Digite a opção Desejada: ");
            short selection = short.Parse(Console.ReadLine());

            switch(selection) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Valeu(); break; //ou System.Environment.Exit(0) para sair
                default: Menu(); break;
            }
        }

        static void Soma() {
            Console.Clear();

            Console.Write("Digite o Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao() {
            Console.Clear();

            Console.Write("Digite o Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 - n2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao() {
            Console.Clear();

            Console.Write("Digite o Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 / n2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao() {
            Console.Clear();

            Console.Write("Digite o Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Valeu() {
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Muito obrigado por utilizar meu sistema. Espero que tenha gostado e volte a usar!");
            Console.WriteLine("Abraço do Luckzin :)");
            Console.WriteLine("---------------------------------------------------------------------------------");
        }
    }
}