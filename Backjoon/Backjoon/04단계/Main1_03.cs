using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class Main1_03
    {
        static void Main1(string[] args)
        {
            int[] input = new int[3];

            
            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

           
            int temp = input[0] * input[1] * input[2];

           
            char[] pieceNum = temp.ToString().ToCharArray();

           
            int count = 0;

           
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < pieceNum.Length; j++)
                {
                    if (pieceNum[j].ToString() == i.ToString())
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                count = 0;

            }

        }
    }
}
