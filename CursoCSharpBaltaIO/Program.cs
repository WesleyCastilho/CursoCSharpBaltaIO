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
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecione uma opção:");
            short escolha = short.Parse(Console.ReadLine());
            Console.WriteLine(escolha);

            switch (escolha)
            {
                case 1: Soma();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Multiplicacao();
                    break;
                case 4: Divisao();
                    break;
            }w
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float soma = v1 + v2;
            Console.WriteLine($"O Resultado da Soma é: {soma}" );
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float subtrai = v1 - v2;
            Console.WriteLine($"O Resultado da Soma é: {subtrai}" );
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float multiplica = v1 * v2;
            Console.WriteLine($"O resultado é: {multiplica}");
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());
            float divisao = v1 / v2;
            Console.WriteLine($"O Resultado é: {divisao}");
        }
    }
}
