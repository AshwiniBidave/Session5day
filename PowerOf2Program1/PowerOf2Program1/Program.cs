using System;

namespace Hormonic

{
    class Program
    {
        static void Main(string[] args)
        {




            double sum = 0;
            Console.WriteLine("Enter number : ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                sum = sum + (double)1 / i;
            }
            Console.WriteLine("nsum=" + sum);
        }
    }
}

