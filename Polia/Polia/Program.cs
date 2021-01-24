using System;

namespace Polia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO1: Maj dvojrozmerné pole kde vnútorné polia majú dĺžku > 5. 
             Na konzolu vypíš prvé dve čísla z každého poľa.
            */

            int[][] pole = new int[2][];
            pole[0] = new int[] { 1, 2, 3, 4, 5, 6 };
            pole[1] = new int[] { 7, 8, 9, 10, 11, 12 };

            //prejdi pole po celej jeho dlzke
            for (int i = 0; i < pole.Length; i++)
            {
                //vypis cisla ktore su na indexe 0 a 1 vnutornych poli  
                Console.WriteLine($"{pole[i][0]},{ pole[i][1]}");
            }

            // TODO2: Na konzolu vypíš súčet a násobok všetkých čísel v jednorozmernom poli */

            int[] array = new int[] { 2, 4, 6, 8, 10 };

            int sum = 0;
            int product = 1;
         

            foreach (int item in array)
            {
                sum += item;
                product = product * item;
           
            }

           
            Console.WriteLine($"Sucet cisel je: {sum}, sucin cisel je: {product}");

            // TODO3:Na konzolu vypíš súčet a násobok všetkých čísel v dvojrozmernom poli.




            /*TODO:Maj dvojrozmerné pole o ľubovoľnej dĺžke.Na konzolu vypíš súčet 0tých, 1vých... ntých(indexi) čísel v poliach.
            Napr.pri dvojrozmernom poli:
            100 50
            0 - 1002

            Napíš na konzolu:
            - Súčet čísel na indexe 0: 10 + 0
            - Súčet na indexe 1: 0 + (-100)
            - Súčet na indexe 2: 50 + 2
            */



        }
    }
}
