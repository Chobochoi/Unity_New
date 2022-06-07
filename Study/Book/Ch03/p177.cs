using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p177
    {
        static void Main1(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요 (짝수 입력 시 종료):");
                int input = int.Parse(Console.ReadLine());
                
                if(input % 2 == 0)
                {
                    break;
                }
            }
        }
    }
}
