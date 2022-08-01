using System;

namespace Swap2no
{
    class Program
    {
        static void Main(string[] args)
        {


            
            int a, b;
            Console.Write("Enter the 1st number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b);

        }
    }
}

