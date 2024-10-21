using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa INVENCÍVEL");

            Run();
        }

        private static void Run()
        {
            Console.Write("Insira um número: ");

            try
            {
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Numero inserido: {i}");
            }

            catch (OverflowException)
            {
                Console.WriteLine($"Error: Number too large...");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
