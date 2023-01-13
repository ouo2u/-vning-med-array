using System;
using System.Security.Cryptography.X509Certificates;

namespace Uppgiftnångot

{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriva in 3 städer");
            string[,] städer = new string[3,3];
            int u = 1;
            for(int i=0; i < städer.Length/3; i++)
            {
                for (int j = 0; j < städer.Length/3; j++)
                {
                    Console.WriteLine($"skriva in städerna " +
                        $"{u}: "); städer[i, j] = Console.ReadLine();
                    u++;
                }
            }
            Console.WriteLine("de städer du har skrivit in är");

            foreach (string städ in städer)
            {
                Console.WriteLine(städ);
            }

        }
    }
}