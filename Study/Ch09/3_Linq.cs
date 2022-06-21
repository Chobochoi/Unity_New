using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/21
이름 최미수
내용 Linq 실습하기 교재 p.525

Linq
Linq(Language Intergrated Query)는 컬렉션 형태의 데이터를 가공처리 하기 위한 C# 질의언어
Linq를 사용해서 DB와 함께 데이터를 쉽게 관리
*/

namespace Ch09
{
    internal class _3_Linq
    {
        class Member
        {
            private string uid;
            private string name;
            private int age;

            public Member(string uid, string name, int age)
            {
                this.uid=uid;
                this.name=name;
                this.age=age;
            }

            public string Uid { get => uid; set => uid=value; }
            public string Name { get => name; set => name=value; }
            public int Age { get => age; set => age=value; }


        }

        static void Main1(string[] args)
        {
            // 컬렉션 생성
            List<int> dataset = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            // 짝수 데이터 추출
            List<int> r1 = new List<int>();
            List<int> r2 = new List<int>();

                        
            // 1. for문 이용
            foreach (int n in dataset)
            {
                if (n%2 ==0)
                {
                    r1.Add(n);
                }
            }

            // 2. 람다식 이용
            dataset.ForEach((n) =>
             {
                 if (n%2 ==0)
                 {
                     r2.Add(n);
                 }
             });
            
            // 3. Linq 이용
            var r3 = from n in dataset where n %2 == 0 select n;

            Console.WriteLine("r1 :"+String.Join(",",r1));
            Console.WriteLine("r2 :"+String.Join(",",r2));
            Console.WriteLine("r3 :"+String.Join(",",r3));

            // dataset에서 데이터가 5 이상 큰 순서대로 출력
            var r4 = from n in dataset where n >= 5 orderby n descending select n;

            Console.WriteLine("r4 :"+String.Join(",", r4));

            // 객체 리스트 Linq 이용
            List<Member> members = new List<Member>();
            members.Add(new Member("a101", "김유신", 25));
            members.Add(new Member("a102", "김춘추", 23));
            members.Add(new Member("a103", "장보고", 35));
            members.Add(new Member("a104", "강감찬", 45));
            members.Add(new Member("a105", "이순신", 55));

            // 30세 이상
            var r5 = from member in members where member.Age > 30 orderby member.Name ascending select member;
            foreach (Member m in r5)
            {
                Console.WriteLine("{0},{1},{2}", m.Uid, m.Name, m.Age);
            }
        }
    }
}
