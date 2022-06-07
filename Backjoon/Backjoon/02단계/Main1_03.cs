using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main1_03
    {
        static void Main1(string[] args)
        {
            string str1 = Console.ReadLine();
            int n1 = int.Parse(str1);

            if(n1%400 == 0)
            {
                Console.WriteLine("1");
            }
            else if(n1%100 == 0)
            {
                Console.WriteLine("0");
            }
            else if(n1%4 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
