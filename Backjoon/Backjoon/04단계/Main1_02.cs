using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class Main1_02
    {
        private static int[] n;
        
        static void Main1(string[] args)
        {
            n = new int[9];
            int max = n[0];
            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
                if(n[i] > max)
                {
                    max = n[i];
                    count = i+1;
                }
            }

            Console.WriteLine("{0}\n{1}", max , count);

        }
    }
}
