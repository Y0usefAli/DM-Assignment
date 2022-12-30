using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inputs
            Console.Write("Enter the 1st number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe perfect numbers from {0} to {1}:", n1, n2);
            //Check
            for (int i = n1; i <= n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
