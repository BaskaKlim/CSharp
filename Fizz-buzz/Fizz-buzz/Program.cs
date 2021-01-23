using System;

namespace Fizz_buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Zadanie: Maj číslo. Ak číslo bude deliteľné číslom 3, tak na výpise konzoly
            // bude text Fizz ak bude deliteľné číslom 5, tak na výpise bude text Buzz.
            // Ak bude číslo zároveň deliteľné 3 a aj 5, tak vypíš FizzBuzz.


            double number;
            //validate input if it is double
            Console.WriteLine("Enter the number: ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("You do not enter correct input, please try again");
            };

            if ((number % 5 == 0) && (number % 3 == 0))
            {
                Console.WriteLine("FizzBuzz");

            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine("The number "+ number + " is not divisible by 3 or 5");
            }
        }
    }
}
