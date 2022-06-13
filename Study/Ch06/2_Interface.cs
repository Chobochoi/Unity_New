using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch06.Sub2;

/*
날짜 2022/06/13
이름 최미수
내용 인터페이스 실습하기 교재 p425

인터페이스(Interface)
Class 간의 공통의 통일된 표준 규격을 통해 Class 구조를 설계하는 문법
Interface를 활용해서 다중 상속을 구현한다.
Interface를 활용해서 객체간 결합도를 완화하는 효과를 얻는다. (다형성)
*/

namespace Ch06
{
    internal class _2_Interface
    {
            // Interface 공통 Class 구조설계
        static void Main1(string[] args)
        {
            IRemoteControl lg = new LGRemocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundUp();
            lg.SoundDown();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundUp();
            samsung.SoundDown();

            // Interface를 활용한 다중 상속
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();
                 
            // Interface를 활용한 결합도 완화
            Bulb bulb = new Bulb();
            ISocket socket = new Cable(bulb);

            socket.SwitchOn();
            socket.SwitchOff();

            
        }
   
    
    }
    
}
