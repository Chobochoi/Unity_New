using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_05
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
                        
            for(int i = a; i > 0; i--)
            {
                sb.Append(i+ "\n");

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
