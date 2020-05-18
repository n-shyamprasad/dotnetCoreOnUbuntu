using System;

namespace fibogen_app
{
    class Program
    {
        static void Main(string[] args)
        {
           var FibGenerator = new FibonacciGenerator();
           foreach(var digit in  FibGenerator.Generate(15))
           {
               Console.WriteLine(digit);
           }
        }
    }
}
