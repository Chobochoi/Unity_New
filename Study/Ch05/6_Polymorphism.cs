using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub5;

/*
날짜 2022/06/09
이름 최미수
내용 다형성 실습하기 교재 p.340

다형성(Polymorphism)
상속관계에서 부모 Class의 기능이 자식 Class에서 여러기능으로 변하는 특성
생성된 객체의 타입선언을 부모 Class 타입으로 선언

*/

namespace Ch05
{
    internal class _6_Polymorphism
    {
        
        
        static void Main1(string[] args)
        {
            // 객체 생성
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark();

            a1.Move();
            a2.Move();
            a3.Move();

            // 객체 타입 캐스팅
            Tiger tiger = (Tiger) a1;
            Eagle eagle = a2 as Eagle;
            Shark shark = (Shark) a3;

            tiger.Hunt();
            eagle.Hunt();
            shark.Hunt();

            // 객체 타입 확인
            if(a1 is Tiger)
            {
                Console.WriteLine("a1은 Tiger 입니다.");
            }

            if(a2 is Eagle)
            {
                Console.WriteLine("a2은 Eagle 입니다.");
            }

            if(a3 is Shark)
            {
                Console.WriteLine("a3은 Shark 입니다.");
            }
         
        }
    }
}
