using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Run();
        }


        private static void Run()
        {
            Console.Write("Insira um número");

            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numero inserido: {i}");
        }
    }
}
