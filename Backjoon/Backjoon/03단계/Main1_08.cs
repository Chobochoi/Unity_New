using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_08
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                sb.Append("Case #" + (i + 1) + ": " + (a) + " + " + (b) + " = " + (a + b) + "\n");
            }
            Console.WriteLine(sb);
        }


    }
}
