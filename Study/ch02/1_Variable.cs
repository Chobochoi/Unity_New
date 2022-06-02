using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/02
이름 최미수
내용 C# 변수 실습 하기 교재 p.79
*/

/* 변수(Variable) : 데이터 처리를 위해 데이터를 저장하는 데이터 그릇
 * 여러번 데이터를 변경할 수 있음
 * 
 * 
 * 상수(Constant) : 데이터를 변경할 수 없는 데이터*/

namespace Ch02
{
    internal class _1_Variable
    {
        static void Main1(string[] args)
        {
            ///////////////////
            // 변수
            ///////////////////
            int num1; // 선언
            num1 = 1; // 대입

            int num2 = 2; // 선언과 초기화

            int num3 = num1 + num2; // 연산

            Console.WriteLine("num3 : "+num3); // 결과값


            ///////////////////
            // 상수
            ///////////////////

            const int NUM = 10;
            const double PI = 3.141592;
            //num = 20;
            //num = 30;

            Console.WriteLine("NUM :" +NUM);
            Console.WriteLine("PI :" +PI);

        }
    }
}
