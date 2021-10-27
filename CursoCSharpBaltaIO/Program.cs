using System;

namespace CursoCSharpBaltaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecione uma opção:");
            short escolha = short.Parse(Console.ReadLine());
            Console.WriteLine(escolha);

            switch (escolha)
            {
                case 1: Adicao();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Multiplicacao();
                    break;
                case 4: Divisao();
                    break;
                case 5: System.Environment.Exit(0);
                    break;
                default: Menu();
                    break;
            }
        }

        static void Banner(string nome)
        {
            Console.WriteLine($"Você selecionou a função: {nome}");
        }
        static void Adicao()
        {
            Console.Clear();
            Banner("Adição");
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float soma = v1 + v2;
            Console.WriteLine($"O Resultado da Soma é: {soma}" );
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Banner("Subtração");
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float subtrai = v1 - v2;
            Console.WriteLine($"O Resultado da Soma é: {subtrai}" );
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Banner("Multiplicação");
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float multiplica = v1 * v2;
            Console.WriteLine($"O resultado é: {multiplica}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Banner("Divisão");
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            if (v2.Equals(0))
            {
                Console.WriteLine("Não é permitido dividir por zero, ainda :)");
                Console.ReadKey();
                Menu();
            }
            float divisao = v1 / v2;
            Console.WriteLine($"O Resultado é: {divisao}");
            Console.ReadKey();
            Menu();
        }
    }
}
