using System;

namespace ConsoleApp_PI_PRIME_NUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime numbers having 3 digits and starting with 5");

            bool primecontrol = false;
            for (int i = 500; i < 600; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if ((i % j == 0)) { primecontrol = true; break; }
                }
                if (!primecontrol) Console.WriteLine(i);
                primecontrol = false;
            }
            Console.ReadKey();

        }
    }
}