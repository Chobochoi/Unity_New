using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class _1_08
    {
        static void Main1(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for(int j =0; j < n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j < 2*i+1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
