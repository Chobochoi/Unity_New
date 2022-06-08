using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p213
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(11);
            list.Add(22);
            list.Add(25);
            list.Add(123);

            foreach(var item in list)
            {
                Console.WriteLine("Count :" +list.Count + "\t item" + item);
            }
        }


    }
}
