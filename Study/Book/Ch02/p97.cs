using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p97
    {
        static void Main1(string[] args)
        {
            int _int = 273;
            long _long = 1231232123;
            float _float = 13.441f;
            double _double = 13.123;
            char _char = '글';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
        }
    }
}
