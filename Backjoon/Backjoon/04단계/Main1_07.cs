using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class Main1_07
    {
        static void Main1(string[] args)
        {
            float count = 0;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] average = Console.ReadLine().Split();

                for(int j = 1; j<average.Length; j++)
                {
                    sum +=int.Parse(average[j]);
                }
                sum = sum / int.Parse(average[0]);

                foreach (var a in average)
                {
                    if (int.Parse(a) > sum)
                    {
                        count++;
                    }
                }

                float avr1 = (count / float.Parse(average[0])) * 100;

                Console.WriteLine($"{avr1:F3}%");

                sum = 0;
                count = 0;

            }
        }
    }
}
