﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._02
{
    internal class _2_04
    {
        static void Main1(string[] args)
        {
            int[] arr = { 4, 2, 1, 5, 3 };

            for (int i = 0; i < 4; i ++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(int n in arr)
            {
                Console.Write(n + " ");
            }
        }
    } 
}
