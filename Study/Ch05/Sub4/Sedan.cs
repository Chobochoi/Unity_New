using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Sedan : Car
    {
        private int cc;

        public Sedan(string name, string color, int speed) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차랑 명 : "+name);
            Console.WriteLine("차랑 색 : "+color);
            Console.WriteLine("차랑 속도 : "+speed);
            Console.WriteLine("차랑 배기량 : "+cc);
            Console.WriteLine("=================");
        }
    }
}
