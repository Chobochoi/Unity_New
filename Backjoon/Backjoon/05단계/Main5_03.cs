using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._05단계
{
    internal class Main5_03
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i < n+1; i++)
            {
                if (numX(i.ToString())) count++;
            }
            Console.WriteLine(count);
        }

        static bool numX(string num)
        {
            // 두자리 수는 다 한수
            if (int.Parse(num) < 100) 
                 return true;
            

            int[] numbers = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                numbers[i] = int.Parse(num[i].ToString());
            }

            if (numbers[0] - numbers[1] == numbers[1] - numbers[2])
            {
                return true;
            }
            else
              { return false; }
                
        }
    }
}
