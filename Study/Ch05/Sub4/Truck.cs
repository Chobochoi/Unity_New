using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Truck : Car
    {
        private int capacity;
        
        public Truck(string name, string color, int speed) : base(name, color, speed)
        {
            this.capacity = capacity;
        }


        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차랑 명 :" +name);
            Console.WriteLine("차랑 색 :" +color);
            Console.WriteLine("차랑 속도 :" +speed);
            Console.WriteLine("차랑 적재량 :" +capacity);
            Console.WriteLine("================");
        }

    }
}
