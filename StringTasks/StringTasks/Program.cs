﻿using System;
using System.Collections.Generic;

namespace StringTasks
{
    class Program
    {


        static void Main(String[] args)
        {
            /*TODO: Napíš metódu, ktorá vstupný string zmení na všetko veľké 
              písmená a vypíše ho na konzolu. */

            Console.WriteLine("Zadaj slovo");
            String inputString = Console.ReadLine();
            UpperString(inputString);

            Console.WriteLine(IsSringEqual());

            static void UpperString(String inputString)
            {
                String outputString = inputString.ToUpper();
                Console.WriteLine($"{outputString}");
            }


            /*TODO: Napíš metódu, ktorá porovná dva string parametre a na konzolu 
             napíše true ak su rovnaké a false ak nie sú rovnaké.  */


             static bool IsSringEqual()
            {
                Console.WriteLine("Zadaj prve slovo");
                String string1 = Console.ReadLine();
                Console.WriteLine("Zadaj druhe slovo");
                String string2 = Console.ReadLine();
                return  string1.Equals(string2);
            
            }

            /*TODO: Predošlú metódu uprav tak, aby namiesto výpisu true a false 
             * vrátila boolean true alebo false. */





        }
    }
}
