using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch02
{
    internal class p111
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.111"));
            Console.WriteLine(double.Parse("52.15"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.111").GetType());
            Console.WriteLine(double.Parse("52.15").GetType());

        }
    }
}
