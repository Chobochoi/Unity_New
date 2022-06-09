using Ch05.Sub4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/09
이름 최미수
내용 Class 상속 실습하기 교재 p.331

상속
기존 Class의 속성과 기능을 그대로 파생 Class로 물려줘 Class를 확장하는 문법
공통적인 내용을 부모 Class에 두고 자식 Class에서 상속 받아 일관성있고 효율적인 프로그래밍 수행
*/


namespace Ch05
{
    class Parent
    {
        private int num1;
        private int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Plus()
        {
            return num1 + num2;
        }

    }

    class Child : Parent
    {
        private int num3;
        private int num4;

        public Child(int num1, int num2, int num3, int num4) : base(num1, num2)
        {
            this.num3=num3;
            this.num4=num4;
        }

        public int Minus()
        {
            return num3 - num4;
        }
    }

    internal class _4_Inheritance
    {
        
        static void Main1(string[] args)
        {
            Child c1 = new Child(1,2,3,4);
            Child c2 = new Child(10,20,30,40);

            Console.WriteLine("c1 Plus :"+c1.Plus());            
            Console.WriteLine("c1 Minus :"+c1.Minus());            
            Console.WriteLine("c2 Plus :"+c2.Plus());            
            Console.WriteLine("c2 Minus :"+c2.Minus());

            // Car 상속 객체 생성
            Sedan sedan = new Sedan("그랜저", "검정색", 0);
            Truck truck = new Truck("트럭", "흰색", 0);

            sedan.SpeedUp(40);
            sedan.Show();

            truck.SpeedUp(70);
            truck.Show();

            // Acount 상속 객체 생성
            StockAccount kb = new StockAccount("kb증권", "111-1111-111","김증권", 1000, "삼성전자", 0, 0);
            kb.Deposit(1000000);
            kb.Buy(10, 70000);
            kb.Sell(5, 75000);
            kb.Show();
        }


    }
}
