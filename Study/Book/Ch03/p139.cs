using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p139
    {
        static void Main1(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            switch(input % 2)
            {
                case 0:
                    Console.WriteLine("짝수");
                    break;
                    
                case 1:
                    Console.WriteLine("홀수");
                    break;
            }
        }
    }
}
