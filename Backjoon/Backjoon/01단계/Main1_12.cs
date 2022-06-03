using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._01단계
{
    internal class Main1_12
    {
        static void Main1(string[] args)
        {
            string[] num1 = Console.ReadLine().Split();
            int n1 = int.Parse(num1[0]);
            int n2 = int.Parse(num1[1]);
            int n3 = int.Parse(num1[2]);

            Console.WriteLine((n1+n2)%n3);
            Console.WriteLine(((n1%n3) +(n2%n3))%n3);
            Console.WriteLine((n1*n2)%n3);
            Console.WriteLine(((n1%n3) * (n2%n3))%n3);
        }
    }
}


// (A+B)%C,
// 둘째 줄에 ((A%C) + (B%C))%C,
// 셋째 줄에 (A×B)%C,
// 넷째 줄에 ((A%C) × (B%C))%C