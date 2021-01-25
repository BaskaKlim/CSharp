using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO:Napíš program, ktorý na konzolu vypíše či je číslo deliteľné 
             * dvomi alebo nie za pomoci ternárneho operátoru. Nemôžeš použiť if.*/

            Console.WriteLine("Zadaj cislo");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((inputNumber % 2 == 0 ? "Cislo je delitelne 2" : "Cislo nie je delitelne 2"));


            /*TODO:Napíš program, ktorý na konzolu vypíše či je číslo > ako 10, 
             * < ako 10 alebo = 10 za pomoci ternárneho operátoru v ternárnom operátore.
             * Nemôžeš použiť if.*/


            Console.WriteLine((inputNumber > 10 ? "Cislo je vacsie ako 10" : (inputNumber < 10 ? "Cislo mensie ako 10": "cislo je rovne 10")));

        }
    }
}
