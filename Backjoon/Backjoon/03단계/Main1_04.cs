using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_04
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());
           

            int[] n1 = new int[a];
            int[] n2 = new int[a];
           
            for (int i = 0; i < a; i++)
            {
                string[] str = Console.ReadLine().Split();
                n1[i] = int.Parse(str[0]);
                n2[i] = int.Parse(str[1]);

                sb.AppendLine((n1[i] + n2[i]).ToString());

            }
            Console.WriteLine(sb.ToString());

        }
    }
}
