using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the nth value as an integer:" );
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Loop calculation: Factorial {n} is {CalculateLooop(n)}");
            Console.ReadKey();
        }
            private static int CalculateLooop(int n)
            {
                var factorial = 1;
                for (int i = n; i >= 1; i--)
                {
                    factorial *= i;
                }
                return factorial;

            }
    }
}
