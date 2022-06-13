using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._04단계
{
    internal class Main1_01
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());

            int[] arr = new int[n1];

            string[] s = Console.ReadLine().Split();

            for (int i = 0; i < n1; i++)
            {
                arr[i] = int.Parse(s[i]);
            }

            Array.Sort(arr);

            Console.WriteLine($"{arr[0]} {arr[n1-1]}");
         

        }
     
        
        
    }
}
