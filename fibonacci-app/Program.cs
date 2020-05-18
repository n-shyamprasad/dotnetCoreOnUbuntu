using System;

namespace fibonacci_app
{
    class Program
    {
        static void Main(string[] args)
        {
           if(args.Length > 0)
           {
                Console.WriteLine($"Hello {args[0]}!");
           }
           else
           {
            Console.WriteLine("Hello..");
           }
           Console.WriteLine("Fibonacci numbers from 1-15:");
            for(int i=0; i<15; i++)
            {
            Console.WriteLine($"{i+1} : {FibonacciNumber(i)} ");
            }
        }

        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int temp;
            for(int i=0; i<n; i++)
            {
                temp = a;
                a = b;
                b = b + temp;
            } 

            return a;               
        }
    }
}
