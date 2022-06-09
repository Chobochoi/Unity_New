﻿using Ch05.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/08
이름 최미수
내용 Class 변수, Class Method 실습하기 교재 p.225

Class 변수(정적 변수, Class Method)
static 변수, Data 영역 메모리 공간에 하나의 Class 변수로 관리
Class 타입(객체 생성 x)으로 직접 참조

싱글톤(Singleton) 객체
Singleton 객체는 하나의 인스턴스만을 갖도록 보장하는 객체이다.
singleton 객체를 활용해서 메모리 절약과 성능 향상을 기대 할 수 있다.
*/

namespace Ch05
{
    class Increment
    {
        public int num1;
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;

            Console.WriteLine("num1 : {0}, num2 : {1}", num1, num2);
        }

        public static void Add()
        {
            // static Method(클래스 Method)에서는 non-static 변수를 참조할 수 없다.
            //num1++;
            num2++;

            Console.WriteLine("num2 :" +num2);
        }

    }
    
    internal class _3_Static
    {
        static void Main1(string[] args)
        {
            Increment inc1 = new Increment();
            Increment inc2 = new Increment();
            Increment inc3 = new Increment();

            // Class 변수, Class Method 실행
            Increment.num2 = 10;
            Increment.Add();

            // Car 객체 생성
            Car car1 = new Car("현대차","검정색",0);
            Car car2 = new Car("기아차","흰색",0);
            Car car3 = new Car("폭스바겐","보라색",0);

            car1.Show();
            car2.Show();
            car3.Show();

            // private 된 Calc 객체 가져오기 (싱글톤)
            Calc cal = Calc.Instance;
            int r1 = cal.Plus(1, 2);

            Console.WriteLine("r1 :" +r1);


        }
    }
}
