using System;

namespace Es1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci codice di verifica:");
            bool x= int.TryParse(Console.ReadLine(), out int codice);

            int originalCodice = codice;
            int temp = 0;
            int somma = 0;
            int numCifre = codice.ToString().Length;
    
            while (codice > 0)
            {
                temp= codice % 10;
                codice = codice / 10;

                somma += (int)Math.Pow(temp, numCifre);

            }
            if (somma == originalCodice)
            {
                Console.WriteLine("Il numero è un numero di Armstrong");
            }
            else
            {
                Console.WriteLine("Il numero non è un numero di Armstrong");
            }
        }
    }
}