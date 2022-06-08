using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# 에서 시간초과 문제를 해결 할 수 있는가??

namespace Backjoon._03단계
{
    internal class Main1_04
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                string[] str = Console.ReadLine().Split();
                int n1 = int.Parse(str[0]);
                int n2 = int.Parse(str[1]);

                Console.WriteLine(n1 + n2);

            }

        }
    }
}
