﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p210
    {
        static void Main1(string[] args)
        {
            Random random = new Random();
            Console.WriteLine(random.NextDouble() *10);
            Console.WriteLine(random.NextDouble() *10);
            Console.WriteLine(random.NextDouble() *10);
            Console.WriteLine(random.NextDouble() *10);
        }
    }
}
