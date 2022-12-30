using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            Console.Write("Enter 1st number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe prime numbers from {0} to {1}:", n1, n2);
            //Check
            for (int i = n1; i <= n2; i++)
            {
                bool prime = true;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}