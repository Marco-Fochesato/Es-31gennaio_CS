using System;

namespace Es3;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero intero positivo:");
            bool x = int.TryParse(Console.ReadLine(), out int n);

            while (!x || n <= 0)
            {
                Console.WriteLine("Numero non valido.");
                Console.WriteLine("Inserisci un numero:");
                x = int.TryParse(Console.ReadLine(), out n);
            }

            Console.Write("Sequenza di Collatz: ");

            while (n != 1)
            {
                Console.Write(n + " -> ");

                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
            }

            Console.WriteLine("1");
        }
    }