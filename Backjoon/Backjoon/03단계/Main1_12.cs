using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_12
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                string[] str1 = Console.ReadLine().Split();

                int n1 = int.Parse(str1[0]);
                int n2 = int.Parse(str1[1]);

                int sum = n1 + n2;

                if (n1 == 0 && n2 ==0)
                {
                    break;
                }

                Console.WriteLine(sum);
            }

        }
    }
}
