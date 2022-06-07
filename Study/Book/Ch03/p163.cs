using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p163
    {
        static void Main1(string[] args)
        {
            int i = 0;
            int[] intArray = { 1, 2, 3, 4, 5 };

            while (i < intArray.Length)
            {
                Console.WriteLine(i + "번째 출력 :" + intArray[i]);

                i++;
            }
        }
    }
}
