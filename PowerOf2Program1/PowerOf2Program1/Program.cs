using System;

namespace QuotientOrReminder
{
    class Program
    {
        static void Main(string[] args)
        {


            int dividend, divisor;
            int remainder = 0;
            Console.Write("Enter the dividend :");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor :");
            divisor = Convert.ToInt32(Console.ReadLine());


            int quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);

        }
    }
}

