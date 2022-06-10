using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_10
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                
                for (int j = a; j > i; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 0; i > k; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
            
        }
    }
}
