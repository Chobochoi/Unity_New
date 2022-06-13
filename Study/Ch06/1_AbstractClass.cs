using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch06.Sub1;


/*
날짜 2022/06/13
이름 최미수
내용 추상 Class 실습하기 교재 p.230

추상 Class (Abstract Class)
공통의 기능은 하나의 Method로 구현하고, 
개별적인 기능은 상속받아 override Method로 구현시키는 추상 Method를 갖는 Class
오직 상속을 목적으로 설계되는 Class
*/
namespace Ch06
{          
    internal class _1_AbstractClass
    {
        static void Main1(string[] args)
        {
            // 추상 Class는 객체 생성 안됨
            // Car car = new Car(); -> X
            
            Car sedan = new Sedan("그랜저", "검정색", 0);
            Car truck = new Truck("포터", "파란색", 0);

            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            truck.SpeedUp(80);
            truck.SpeedDown(10);
            truck.Show();
            
        }
    }
}
