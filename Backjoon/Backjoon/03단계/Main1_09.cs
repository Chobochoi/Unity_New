using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_09
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
                
        }
    }
}
