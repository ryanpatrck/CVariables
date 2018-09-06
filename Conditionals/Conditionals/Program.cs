using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is "+ max);
        }
  

    }
}
