using System;
using System.Collections.Generic;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TODO: Napíš program, ktorý vytvorí priemer zo známok (ľubovoľný počet int-ov)
            a na konzolu za pomoci switchu napíš akú známku bude na vysvedčení.
            Ak je priemer > 1.5 tak na vysvedčení bude 2. Ak je priemer < ako 1.5,
            tak na vysvedčení bude 1, takto to sprav pre všetky známky.
             */

             double avg = 0.0;
             double sum = 0;
             int mark;

            List<int> marks = new List<int>();

            Console.WriteLine("Kolko znamok z predmetu chces zadat?");
            int numberInput= Convert.ToInt32(Console.ReadLine());

            for(int i =1; i<= numberInput; i++)
            {
                Console.WriteLine($"{i}. znamka z predmetu je: ");
                int input = Convert.ToInt32(Console.ReadLine());
                marks.Add(input);
            }
         

            foreach (int item in marks)
            {
                sum += item;
      
                avg = sum / numberInput;
            }

            Console.WriteLine($"Sucet znamok je: {sum}");
            Console.WriteLine($"Priemer znamok je: {avg}");

            if (avg < 1.5)
            {
                mark = 1;
            }
            else if (avg < 2.5)
            {
                mark = 2;
            }
            else if (avg < 3.5)
            {
                mark = 3;
            }
            else if (avg < 4.5)
            {
                mark = 4;
            }
            else
                mark = 5;

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Známka na vysvedční bude: 1");
                    break;
                case 2:
                    Console.WriteLine("Známka na vysvedční bude: 2");
                    break;
                case 3:
                    Console.WriteLine("Známka na vysvedční bude: 3");
                    break;
                case 4:
                    Console.WriteLine("Známka na vysvedční bude: 4");
                    break;
                case 5:
                    Console.WriteLine("Známka na vysvedční bude: 5");
                    break;
                default:
                    break;
            }

           // Console.WriteLine($"Znamka z tohto predmetu na vysvedceni bude: {mark}");
       
        }
    }

}



