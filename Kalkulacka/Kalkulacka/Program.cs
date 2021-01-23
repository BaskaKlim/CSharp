using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Write first number and press Enter");
            int number1;
            //adding validation of input if it is integer and parsign into output 
            while (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("You did not enter correct input, please try again" +
                    " and press Enter");
            }
            Console.WriteLine("Write second number and press Enter");
            int number2;
            //adding validation of input if it is integer and parsign into output 
            while (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("You did not enter correct input, please try again" +
                    " and press Enter");
            }

            Console.WriteLine("Choose operation:");
            Console.WriteLine("\t+");
            Console.WriteLine("\t-");
            Console.WriteLine("\t*");
            Console.WriteLine("\t/");

            String operation = Console.ReadLine();
            //options

            Console.WriteLine("Result is: ");

            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    Console.WriteLine(number1 / number2);
                    break;
            }
        }
    }
}
