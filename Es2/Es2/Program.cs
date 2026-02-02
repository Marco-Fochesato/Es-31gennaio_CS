using System;

namespace Es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero:");
            bool x = int.TryParse(Console.ReadLine(), out int num1);

            Console.WriteLine("Inserisci il secondo numero:");
            bool y = int.TryParse(Console.ReadLine(), out int num2);

            while (!x || !y || num1 <= 0 || num2 <= 0)
            {
                Console.WriteLine("Inserisci due numeri interi positivi validi.");
                Console.WriteLine("Inserisci il primo numero:");
                x = int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Inserisci il secondo numero:");
                y = int.TryParse(Console.ReadLine(), out num2);
            }

            int sommaDiv1 = 0;
            int sommaDiv2 = 0;

            // Calcolo somma divisori del primo numero
            for (int i = 1; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    sommaDiv1 += i;
                }
            }

            // Calcolo somma divisori del secondo numero
            for (int i = 1; i <= num2 / 2; i++)
            {
                if (num2 % i == 0)
                {
                    sommaDiv2 += i;
                }
            }

            if (sommaDiv1 == num2 && sommaDiv2 == num1)
            {
                Console.WriteLine($"{num1} e {num2} sono numeri amici.");
            }
            else
            {
                Console.WriteLine($"{num1} e {num2} NON sono numeri amici.");
            }
        }
    }
}
