using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        // 속성(필드) 상속 관계에서 자식 Class가 참조 할 수 있는 방법
        // private -> protected로 변경하면 가능
        protected string name;
        protected string color;
        protected int speed;

        public Car(string name, string color, int speed)
        {
            this.name=name;
            this.color=color;
            this.speed=speed;
        }
          

        // 기능(Method)
        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }
        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }
        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차랑 명 :" +name);
            Console.WriteLine("차랑 색 :" +color);
            Console.WriteLine("차랑 속도 :" +speed);
        }
    }
}
