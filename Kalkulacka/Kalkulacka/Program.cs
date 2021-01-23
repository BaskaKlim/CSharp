using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            String inputNumber1 = Console.ReadLine();
            int number1 = Convert.ToInt32(inputNumber1);
            String inputNumber2 = Console.ReadLine();
            int number2 = Convert.ToInt32(inputNumber2);

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
