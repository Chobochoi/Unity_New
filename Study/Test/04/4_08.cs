﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._04
{
    class Apple
    {
        public void Show()
        {
            Console.WriteLine("사과입니다.");
        }
    }
    class Banana
    {
        public void Show()
        {
            Console.WriteLine("바나나입니다.");
        }
    }
    class Grape
    {
        public void Show()
        {
            Console.WriteLine("포도입니다.");
        }
    }

    internal class _4_08
    {
        static void Main1(string[] args)
        {
            Apple apple = new Apple();
            Banana banana = new Banana();
            Grape grape = new Grape();

            Show(apple);
            Show(banana);
            Show(grape);
        }

        public static void Show(object fruit)
        {
            if (fruit is Apple)
            {
                Apple apple = (Apple) fruit;
                apple.Show();
            }
            else if (fruit is Banana)
            {
                Banana banana = fruit as Banana;
                banana.Show();
            }
            else if (fruit is Grape)
            {
                Grape grape = fruit as Grape;
                grape.Show();
            }
        }
    }
}
