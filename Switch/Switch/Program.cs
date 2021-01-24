using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TODO:
            Napíš program, ktorý na základe čísla napíše hlášku. Ak 1, tak sa vypíše: Je pondelok.
            Ak 2, tak sa vypíše: Je utorok. A tak podobne pre všetky dni. Jedine ak 6 alebo 7,
            tak sa vypíše: Je víkend. Ak by si mal hocičo iné, tak na konzolu napíšeš:
            Nezadal si dobré číslo dňa.
             */

            Console.WriteLine("Zadaj cislo dna: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Pondelok");
                    break;
                case 2:
                    Console.WriteLine("Utorok");
                    break;
                case 3:
                    Console.WriteLine("Streda");
                    break;
                case 4:
                    Console.WriteLine("Stvrtok");
                    break;
                case 5:
                    Console.WriteLine("Piatok");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Vikend");
                    break;
                default:
                    Console.WriteLine("Nezadal si dobre cislo");
                    break;
            }

        }
    }
}

