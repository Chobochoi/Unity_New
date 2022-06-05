using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main1_05    
    {
        static void Main1(string[] args)
        {
            string[] str1 = Console.ReadLine().Split();

            int H = int.Parse(str1[0]);
            int M = int.Parse(str1[1]);

            if (H < 0 || H > 23 || M < 0 || M > 59)
               return;
            
            if (M < 45)
            {
                H--;
                M += 15;

                if (H < 0)
                {
                    H = 23;
                }
            }
            else
            {
                M -= 45;
            }

            Console.WriteLine("{0} {1}", H, M);
            
               
        }
    }
}
