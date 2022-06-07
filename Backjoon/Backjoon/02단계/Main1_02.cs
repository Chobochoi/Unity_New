using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon._02단계
{
    internal class Main1_02
    {
        static void Main1(string[] args)
        {
            
            string strScore = Console.ReadLine();

            int score = int.Parse(strScore);
            int grade = score/10;

            if (grade == 10)
            {
                Console.WriteLine("A");                    
            }
            if (grade == 9)
            {
                Console.WriteLine("A");
            }
            if (grade == 8)
            {
                Console.WriteLine("B");
            }
            if (grade == 7)
            {
                Console.WriteLine("C");
            }
            if (grade == 6)
            {
                Console.WriteLine("D");
            }
            if (grade == 5)
            {
                Console.WriteLine("F");
            }
            if (grade == 4)
            {
                Console.WriteLine("F");
            }
            if (grade == 3)
            {
                Console.WriteLine("F");
            }
            if (grade == 2)
            {
                Console.WriteLine("F");
            }
            if (grade == 1)
            {
                Console.WriteLine("F");
            }
            if (grade == 0)
            {
                Console.WriteLine("F");
            }



        }
    }
}
