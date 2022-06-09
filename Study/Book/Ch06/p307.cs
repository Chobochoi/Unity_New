using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p307
    {
        class Fibonacci
        {
            public long Get(int i)
            {
                if(i<0)
                {
                    return 0;
                }
                if (i ==1)
                {
                    return 1;
                }
                return Get (i-2) + Get (i-1);
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Fibonacci fibon = new Fibonacci();
                Console.WriteLine(fibon.Get(1));
                Console.WriteLine(fibon.Get(2));
                Console.WriteLine(fibon.Get(3));
                Console.WriteLine(fibon.Get(4));
            }
        }
    }

}
