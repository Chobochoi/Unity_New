using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._03단계
{
    internal class Main1_13
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                    break;

                string[] str1 = input.Split();

                int n1 = int.Parse(str1[0]);
                int n2 = int.Parse(str1[1]);

                int sum = n1 + n2;

                Console.WriteLine(sum);
            }


        }
    }
}
