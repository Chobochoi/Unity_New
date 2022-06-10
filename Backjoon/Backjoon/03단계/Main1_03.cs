using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_03
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= a; i++)
            {
                sb.Append(i+ "\n");
            }

            Console.WriteLine(sb.ToString());
            
        }
    }
}
