using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p129
    {
        static void Main1(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전");
            }
            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후");
            }
        }
    }
}
