using System;

namespace EvenOrOdd

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("It is even number");
            }
            else
            {
                Console.WriteLine("It is odd number");
            }
        }
    }
}

