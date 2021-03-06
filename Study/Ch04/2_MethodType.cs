using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/07
이름 최미수
내용 MethodType 실습 교재 p. 265
*/

namespace Ch04
{
    internal class _2_MethodType
    {
        static void Main1(string[] args)
        {
            // Method 호출
            double y1 = Type1(0.1); // 인자값 0.1 대입
            double y2 = Type1(1.2); // 인자값 1.2 대입

            Console.WriteLine("y1 :" +y1);
            Console.WriteLine("y2 :" +y2);

            Type2(true); // 반환값이 없으므로 대입연산자 필요없음.
            Type2(false);

            string result = Type3();
            Console.WriteLine("Type3 result :" +result);

            Type4();

        }

        // Type1 : 매개변수 o, 리턴 값 o
        public static double Type1(double x)
        {
            double y = x + 3.14;
            return y;
        }

        // Type2 : 매개변수 o, 리턴 값 x
        public static void Type2(bool status)
        {
            if(status)
            {
                Console.WriteLine("참 입니다.");
            }
            else
            {
                Console.WriteLine("거짓 입니다.");
            }
        }
        // Type3 : 매개변수 x, 리턴 값 o
        public static string Type3()
        {
            int n1 = 1, n2 = 2;

            if (n1 > n2)

                return "n1은 n2보다 크다.";
            else
                return "n1은 n2보다 작다.";
             
        }
        // Type4 : 매개변수 x, 리턴 값 x
        public static void Type4()
        {
            double result = Type1(1.121);
            Console.WriteLine("Type4 result :" +result);
        }
    }
}
