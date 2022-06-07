using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p174
    {
        static void Main1(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i+1; j++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();
            }
           
        }
    }
}
