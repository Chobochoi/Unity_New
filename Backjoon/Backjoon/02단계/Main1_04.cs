using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Backjoon._02단계
{
    internal class Main1_04
    {
        static void Main1(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();
            int n1 = int.Parse(str1[0]);
            int n2 = int.Parse(str1[1]);

            if (n1 == 0)
            {
                if(n2 == 0)
                return;
            }
            if (n1 > 0)
            {
                if (n2 > 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("4");
                }
            }
            if (n1 < 0)
            {
                if (n2 > 0)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("3");
                }

            }
        }
    }
}
