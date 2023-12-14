using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dec14
{
    internal class vro
    {
        //static void Fun1(int insideVar)
           //  static void Fun1(ref int insideVar)
             static void Fun1(out int insideVar)
        {
            insideVar = 0;
            insideVar = insideVar + 20;
        }
        static void Main(string[] args)
        {
            int outsideVar = 10;
            //  Fun1(outsideVar);
            // Fun1(ref outsideVar);
            Fun1(out outsideVar);
            Console.WriteLine(outsideVar);

            //boxing
            int x = 10;//value type
            Object y;//RT 
            y = x;
            Console.WriteLine($"boxing {y}");

            //outboxing
            Object a = 10;
            int b;
            b = (int)a;// unboxing
            Console.WriteLine($"unboxing {b}");


            Console.Read();

        }

    }
}
