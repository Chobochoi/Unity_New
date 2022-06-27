using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._07
{
    internal class _7_09
    {
        enum Size { Short, Tall, Grande, Venti };
        enum Coffe { Short = 3300, Tall = 3800, Grande = 4300, Venti =4800 };

        static void Main1(string[] args)
        {
            Console.WriteLine("커피 가격표");

            for (int i = 0; i<4; i++)
            {
                if (i == (int)Size.Short)
                {
                    Console.WriteLine("{0,10}:{1:C}",Size.Short, Convert.ToInt32(Coffe.Short));
                    //tall grande venti 순서로
                }
            }

        }
    }
}
