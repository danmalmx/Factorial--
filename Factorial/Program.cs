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
            Console.WriteLine($"Recusrive calculation: Factorial {n} is {CalculateRecursion(n)}");

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

        private static int CalculateRecursion(int n)
        {
            if (n == 1)
                return 1;
            return n * CalculateRecursion(n - 1);
        }
    }
}
