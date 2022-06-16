using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._02
{
    internal class _2_05
    {
        static void Main1(string[] args)
        {
            
            // 선행조건 : 원소의 배열이 정리가 되어있어야 한다.
            int[] arr = { 5, 10, 18, 22, 35, 55, 75, 103, 152 };

            Console.Write("검색할 숫자 입력 : ");
            int value = int.Parse(Console.ReadLine());

            int start = 0;
            int end = arr.Length-1;
            int loc = 0;
            bool state = false;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] > value)
                {
                    end = mid-1;
                }
                else if (arr[mid] < value)
                {
                    start = mid+1;
                }
                else
                {
                    loc = mid;
                    state = true;
                    break;

                }
            }

            if (state)
                Console.WriteLine("찾은 위지 : {0}번째 있습니다.", loc + 1);
            else
                Console.WriteLine("찾는 숫자가 없습니다.");

        }
    }
}
