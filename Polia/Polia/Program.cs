using System;

namespace Polia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO: Maj dvojrozmerné pole kde vnútorné polia majú dĺžku > 5. 
             Na konzolu vypíš prvé dve čísla z každého poľa.
            -Na konzolu vypíš súčet a násobok všetkých čísel v jednorozmernom poli.
            -Na konzolu vypíš súčet a násobok všetkých čísel v dvojrozmernom poli.
            */

            int[][] pole = new int[2][];
            pole[0] = new int[] { 1, 2, 3, 4, 5, 6 };
            pole[1] = new int[] { 7, 8, 9, 10, 11, 12 };


            for (int i = 0; i < pole.Length; i++)
            {
               
                Console.WriteLine($"{pole[i][0]},{ pole[i][1]}");
            }
                   
 



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
