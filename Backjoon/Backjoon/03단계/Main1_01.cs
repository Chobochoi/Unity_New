using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오.
// 출력 형식에 맞춰서 출력하면 된다.
namespace Backjoon._03단계
{
    internal class Main1_01
    {
        static void Main1(string[] args)
        {
            string num1 = Console.ReadLine();
            int n1 = int.Parse(num1);

            for(int i = 1; i <= 9; i++)
            {
                int j = n1 * i;
                Console.WriteLine("{0} * {1} = {2}", n1 , i, j);
            }

        }                
    }
}
