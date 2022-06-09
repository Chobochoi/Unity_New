using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/09
이름 최미수
내용 Override 실습하기 교재 p.361

오버라이드(Override)
부모 Class의 Method를 자식 Class에서 다시 재정의(덮어쓰기) 하는 것
오버라이드(Override)를 통해 다형성을 실현한다.
*/

namespace Ch05
{
    class AAA 
    {
        public void Method1()
        {
            Console.WriteLine("AAA : Method1 ...");
        }
        public virtual void Method2()
        {
            Console.WriteLine("AAA : Method2 ...");
        }
        public virtual void Method3()
        {
            Console.WriteLine("AAA : Method3 ...");
        }

    }
    class BBB  : AAA
    {

        // Method Hiding : BBB의 Method1이 AAA의 Method1을 숨김. 하지만 new 잘 쓰지 않음.
        public new void Method1()
        {
            Console.WriteLine("BBB : Method1 ...");
        }

        // Method Override : BBB의 Method2가 AAA의 Method2를 덮어씌움. AAA를 virtual로 만들 것.
        public override void Method2()
        {
            Console.WriteLine("BBB : Method2 ...");
        }
        
        // Method Overload : BBB의 Method3와 AAA의 Method3이 매개변수로 구분
        public void Method3(int a)
        {
            Console.WriteLine("BBB : Method3 ...");
        }
    }
    class CCC  : BBB
    {
        
        // CCC의 Method1이 BBB Method1을 숨김. 하지만 new 잘 쓰지 않음.
        public new void Method1()
        {
            Console.WriteLine("CCC : Method1 ...");
        }
        
        // CCC의 Method2가 BBB의 Method2를 덮어씌움.
        public override void Method2()
        {
            Console.WriteLine("CCC : Method2 ...");
        }
                      
        // CCC의 Method3이 AAA의 Method3를 덮어씌움. AAA에 virtual이 필요. BBB에 매개변수가 있음.
        public override void Method3()
        {
            Console.WriteLine("CCC : Method3 ...");
        }
    }

    internal class _5_Override
    {
        static void Main1(string[] args)
        {
            AAA a = new AAA();
            BBB b = new BBB();
            CCC c = new CCC();

            a.Method1();
            a.Method2();
            a.Method3();
            Console.WriteLine();

            b.Method1();
            b.Method2();
            b.Method3();
            Console.WriteLine();

            c.Method1();
            c.Method2();
            c.Method3();
            c.Method3(1);
            Console.WriteLine();

        }
    }
}
