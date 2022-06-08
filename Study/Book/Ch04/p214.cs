using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p214
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>() { 11, 12, 13, 14 };

            list.Remove(11);

            foreach(var item in list)
            {
                Console.WriteLine("Count :" +list.Count + "item :" +item);
            }
        }
    }
}
