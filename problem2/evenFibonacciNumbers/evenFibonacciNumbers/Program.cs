using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibA = 0;
            int fibB = 1;
            int result = 0;
            int sum = 0;

            while (result < 4000000)
            {
                result = fibA + fibB;
                fibA = fibB;
                fibB = result;

                if (result % 2 == 0)
                {
                    sum += result;
                }

            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
