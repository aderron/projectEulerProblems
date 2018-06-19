using System;

namespace PRIME_T_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a;

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (IsPrime(a) == true)
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }

            Console.ReadLine();
        }

        static bool IsPrime(int b)
        {
            if (b <= 1)
                return false;

            for (int n = 2; n <= b / 2; n++)
            {
                if (b % n == 0)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
