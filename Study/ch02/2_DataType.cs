using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/02
이름 최미수
내용 C# 자료형(DataType) 실습하기 교재 p.83
*/

/* 자료형(DataType)
 * 변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언
 * 자료형은 크게 기본형과 참조형으로 나뉨
 */


namespace Ch02
{
    internal class _2_DataType
    {
        static void Main2(string[] args)
        {
            // 정수형
            sbyte num1 = 127;
            byte num2 = 255;
            short num3 = 32767; 
            int num4 = 2147483647;
            long num5 = 2147483467L;

            Console.WriteLine("num1 :{0}" ,num1);
            Console.WriteLine("num2 :{0}" ,num2);
            Console.WriteLine("num3 :{0}" ,num3);
            Console.WriteLine("num4 :{0}" ,num4);
            Console.WriteLine("num5 :{0}" ,num5);

            // 실수형
            float var1 = 1.12312312f; // 8자리까지
            double var2 = 1.12312312346456; // 16자리까지

            Console.WriteLine("var1 :" +var1);
            Console.WriteLine("var2 :" +var2);

            // 논리형
            bool b1 = true;
            bool b2 = false;

            Console.WriteLine("b1 :" +b1);
            Console.WriteLine("b2 :" +b2);

            // 문자형
            char c1 = 'A';
            char c2 = '가';

            Console.WriteLine("c1 :" +c1);
            Console.WriteLine("c2 :" +c2);

            // 문자열
            string str1 = "A";
            string str2 = "안녕하세요";

            Console.WriteLine("str1 :" + str1);
            Console.WriteLine("str2 :" + str2);

            // object형
            // 참조값으로 저장하는 것 
            object obj1 = 11;
            object obj2 = 3.13124;
            object obj3 = true;
            object obj4 = "a";
            object obj5 = 'A';

            Console.WriteLine("obj1 :"+obj1);
            Console.WriteLine("obj2 :"+obj2);
            Console.WriteLine("obj3 :"+obj3);
            Console.WriteLine("obj4 :"+obj4);
            Console.WriteLine("obj5 :"+obj5);

            // var형
            var v1 = 11;
            var v2 = 13.56;
            var v3 = true;
            var v4 = 'A';
            var v5 = "a";

            Console.WriteLine("var1 :" +v1);
            Console.WriteLine("var2 :" +v2);
            Console.WriteLine("var3 :" +v3);
            Console.WriteLine("var4 :" +v4);
            Console.WriteLine("var5 :" +v5);
        }
    }
}
