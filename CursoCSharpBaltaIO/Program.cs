using System;

namespace CursoCSharpBaltaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
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
    }
}
