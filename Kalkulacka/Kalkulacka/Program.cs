using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            String operation = Console.ReadLine();
            //options

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
