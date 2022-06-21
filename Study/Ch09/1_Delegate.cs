using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/21
이름 최미수
내용 Delegate 실습하기 교재 p.493

대리자(Delegate)
대리자는 Method에 대한 참조를 나타내는 형식으로 Method를 대신 호출해주는 역할
대리자를 익명 Method로 많이 활용
*/

namespace Ch09
{
    // 대리자 선언
    public delegate int MyDelegate(int x, int y);
    public delegate int SumDelegate(int[] arr);

    internal class _1_Delegate
    {
        static void Main1(string[] args)
        {
            // 대리자 초기화(Method 참조)
            MyDelegate my1 = new MyDelegate(Plus);
            MyDelegate my2 = new MyDelegate(Minus);

            int r1 = my1(1, 2);
            int r2 = my2(2, 3);
            Console.WriteLine("r1 :" +r1);
            Console.WriteLine("r2 :" +r2);

            // 대리자 활용(Method의 매개변수로 대리자 선언)
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int rs1 = Sum(arr, OddSum); // 행위(Method)를 전달하기 위해 대리자 사용
            int re2 = Sum(arr, EvenSum);

            // 대리자를 익명 Method로 활용
            var md = delegate (int x, int y)
            {
                return x + y;
            };

            int result1 = md(2, 3);
            int result2 = md(3, 4);
            Console.WriteLine("result :"+result1);
            Console.WriteLine("result :"+result2);

            List<int> dataset = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            dataset.ForEach(delegate (int n)
            {
                Console.WriteLine(n+" ");
            });

            foreach (int n in dataset)
            {
                Console.WriteLine(n+" ");
            }



        }

        public static int Plus(int x, int y)
        {
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            return x - y;
        }
        public static int OddSum(int[] arr)
        {
            int sum = 0;

            foreach (int n in arr)
            {
                if (n %  2 == 1)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public static int EvenSum(int[] arr)
        {
            int sum = 0;

            foreach (int n in arr)
            {
                if (n %  2 == 0)
                {
                    sum += n;
                }
            }

            return sum;
        }

        public static int Sum(int[] arr, SumDelegate sumDelegate)
        {
            return sumDelegate(arr);
        }
    }
}
