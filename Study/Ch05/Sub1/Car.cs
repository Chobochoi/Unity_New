﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {
        // 속성(필드)
        public string name;
        public string color;
        public int speed;


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
