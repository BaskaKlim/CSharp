using System;

namespace Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO:
             * Napíš metódu, ktorá na vstupe bude prijímať číslo. Toto číslo hovorí o tom koľko riadkov sa vypíše na konzolu. Na konzolu vypíš takéto tvary. Pre každý tvar sprav osobitnú metódu.

                1. tvar:

                Ak zadáš do metódy číslo 3:

                * * *

                * *

                *

                Ak zadáš do metódy číslo 5:

                * * * * *

                * * * *

                * * *

                * *

                *

             */
            Console.WriteLine("Zadaj pocet riadkov: ");
            int pocetRiadkov = Convert.ToInt32(Console.ReadLine());
            Shape(pocetRiadkov);

            static void Shape(int pocetRiadkov)
            {
                if (pocetRiadkov>0)
                {
                    for (int i = 0; i < pocetRiadkov; i++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                    
                    Shape(--pocetRiadkov);
                }
                
            }

        }
    }
}
