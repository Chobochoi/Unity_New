using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//첫째 줄에 테스트 케이스의 개수 T가 주어진다.
//각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

namespace Backjoon._03단계
{
    internal class Main1_02
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                string[] str = Console.ReadLine().Split();
                int n1 = int.Parse(str[0]);
                int n2 = int.Parse(str[1]);

                Console.WriteLine(n1 + n2);

            }

        }
    }
}
