﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch03
{
    internal class p133
    {
        static void Main1(string[] args)
        {
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹어");
            }

            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹어");
                }
                else
                {
                    Console.WriteLine("저녁 먹어");
                }
            }
        }
    }
}
