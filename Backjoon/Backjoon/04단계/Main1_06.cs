using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class Main1_06
    {

        static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] newCase = new string[n];

            for (int i = 0; i < n; i++)
            {
                newCase[i] = Console.ReadLine();
                char[] temp = newCase[i].ToCharArray();
                int j = 0;
                int result1 = 0;
                int score = 0;

                while (true)
                {
                    if (temp[j].ToString() == "O")
                    {
                        score++;
                        result1 += score;
                    }
                    else
                    {
                        score = 0;
                    }
                    j++;

                    if (j == temp.Length) break;
                }
                Console.WriteLine(result1);
            }

        }
        
        
      


    }
}
