using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 2022/06/14
이름 최미수
내용 인덱서 실습하기 교재 p398

인덱서(Indexer)
객체를 비열처럼 인덱스를 사용해서 객체의 데이터를 참조 할 수 있게 해주는 속성
Indexer를 Method로 대체 가능
*/

namespace Ch06
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        // Indexer
        public int this[int i]
        {
            get { return array[i]; }
            set
            {
                if( i < array.Length )
                {
                    array[i] = value;
                }
                else 
                {
                    Console.WriteLine("더 이상 데이터를 저장 할 수 없습니다.");
                } 
            }
        }

        public int Length()
        {
            return array.Length;
        }

    }
        

    
    internal class _5_Indexer
    {
        static void Main1(string[] args)
        {
            MyList myList = new MyList();

            // myList의 index 값 추출
            // 첫 번째 배열의 값 : 100 
            // 두 번째 배열의 값 : 200 
            // 세 번째 배열의 값 : 300 
                       
            myList[0] = 100;
            myList[1] = 200;
            myList[2] = 300;
            myList[3] = 400; // 더 이상 출력 X

            for (int i = 0; i < myList.Length(); i++)
            {
                Console.WriteLine(myList[i]);
            }

        }
    }
}
