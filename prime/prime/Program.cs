using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Liczby pierwsze pomiędzy 0 i 100 ---");

            for (int i = 0; i < 100; i++)
            {
                bool prime = PrimeTool.IsPrime(i);

                if (prime)
                {
                    Console.Write("Pierwsze: ");
                    Console.WriteLine(i);
                }
            }
        }
    }
}
