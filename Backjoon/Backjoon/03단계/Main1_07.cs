using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_07
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int a = int.Parse(Console.ReadLine());

            //int[] n1 = new int[a];
            int n1;


            for (int i = 0; i < a; i++)
            {
                string[] s = Console.ReadLine().Split();
                n1 = int.Parse(s[0]) + int.Parse(s[1]);

                sb.Append("Case #" + (i+1) +": "+ n1 +"\n");

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
