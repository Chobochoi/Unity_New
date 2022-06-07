using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/07
이름 최미수
내용 MethodOverload 실습 교재 p. 275

MethodOverloading
같은 이름의 Method를 매개변수(Parameter)로 구분한 Method
Method 반환타입은 Overloading에 영향을 미치지 않는다.

*/

namespace Ch04
{
    internal class _3_MethodOverload
    {
        static void Main1(string[] args)
        {
            int r1 = Plus(1, 2);
            int r2 = Plus(1, 2, 3);
            double d1 = Plus(1.01, 2.3);
            string s1 = Plus("가", "나");

            Console.WriteLine("r1 :" +r1);
            Console.WriteLine("r2 :" +r2);
            Console.WriteLine("d1 :" +d1);
            Console.WriteLine("s1 :" +s1);

        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static string Plus(string a, string b)
        {
            return a + b;
        }
    }

}
