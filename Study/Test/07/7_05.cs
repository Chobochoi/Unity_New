using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._07
{
    internal class _7_05
    {
        static void Main1(string[] args)
        {
            int first = 10; 
            int second = 20;
            bool result = true;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first < second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first >= second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first != second);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = (first == second) && (first > 5);
            Console.WriteLine("{0} == {1} : {2}", first, second, result);

            result = true ^ false;
            Console.WriteLine("{0} ^ {1} : {2}",true, false , result);
        }
    }
}
