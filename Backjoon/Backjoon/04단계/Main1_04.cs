using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class Main1_04
    {
        static void Main(string[] args)
        {
            int[] input = new int[10];
            int result = 0;

            for(int i = 0; i < 10; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                input[i] = input[i] % 42 ;
            }

            for(int i =0; i < input.Length; i++)
            {
                int count = 0;
                for(int j = i+1; j< input.Length; j++)
                {
                    if(input[j] == input[i])
                          count++;
                    
                   
                }
                if (count == 0) result++;

                
            }

            Console.WriteLine(result);

            



        }
    }
}
