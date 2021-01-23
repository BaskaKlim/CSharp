using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Write first number and press Enter");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number and press Enter");
            int number2 = Convert.ToInt32(Console.ReadLine());
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
