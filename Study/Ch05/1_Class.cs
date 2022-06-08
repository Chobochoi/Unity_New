using Ch05.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/08
이름 최미수
내용 클래스와 객체 실습하기 교재 p.203

클래스와 객체
클래스는 객체를 생성하는 구조체이며, 필드와 Method로 구성된다.
객체는 클래스의 실제 인스턴스이며, new 연산자로 생성한다.
 */

namespace Ch05
{
    internal class _1_Class
    {
        static void Main1(string[] args)
        {
            // 객체 생성
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            // 객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);

            sonata.Show();

            // 객체 생성
            Car bmw = new Car();

            // 객체 초기화
            bmw.name = "BMW";
            bmw.color = "검정색";
            bmw.speed = 0;

            // 객체 기능
            bmw.SpeedUp(100);
            bmw.Show();

            // Account 객체 생성
            Account kb = new Account();

            // 초기화
            kb.bank = "국민은행";
            kb.id = "101-22-222-222";
            kb.name = "김유신";
            kb.balance = 10000;

            // 기능
            kb.Deposit(25000);
            kb.Withdraw(10000);
            kb.Show();

            // Account 객체 생성
            Account nh = new Account();

            // 초기화
            nh.bank = "농협";
            nh.id = "123-1231-123";
            nh.name = "김농협";
            nh.balance = 30000;

            nh.Deposit(50000);
            nh.Withdraw(10000);
            nh.Show();


        }
    }
}
