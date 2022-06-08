using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/08
이름 최미수
내용 캡슐화 실습하기 교재 p.203

캡슐화(Encapsulation)
캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성
캡슐화를 위한 접근 제한자 public private protected를 제공한다.
은닉된 정보의 안전한 제공을 위해 Getter Setter를 제공한다.(프로피티)
*/

namespace Ch05
{
    internal class _2_Encaps
    {
        static void Main1(string[] args)
        {
            Account kb = new Account
                (
                "국민은행", 
                "111-1111-1111",
                "김국민",
                10000
                );
            

            kb.Deposit(5000);
            kb.Withdraw(3000);

            // 캡슐화로 취약 코드 예방
            //kb.balance--;
            //kb.balance += 10;

            kb.Show();

            Car a = new Car("티코", "파란색", 100);
            
            // setter 실행
            a.Name = "황금티코";
            a.Speed = 100;

            // getter 실행
            Console.WriteLine("a 객체 name :" +a.Name);

            a.SpeedDown(50);
            a.Show();


        }
    }
}
