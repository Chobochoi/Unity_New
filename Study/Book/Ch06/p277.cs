using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch06
{
    internal class p277
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0)
                {
                    return -input;
                }

                else
                {
                    return input;
                }
            }

            public static double Abs(double input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }

            }
            

            public static long Abs(long input)
            {
                if (input < 0)
                {
                    return -input;
                }

                else
                {
                    return input;
                }
            }
        }

        static void Main1(string[] args)
        {
            Console.WriteLine(MyMath.Abs(11));
            Console.WriteLine(MyMath.Abs(-15));
           
            Console.WriteLine(MyMath.Abs(55.222));
            Console.WriteLine(MyMath.Abs(-11.123));


            Console.WriteLine(MyMath.Abs(112313141));
            Console.WriteLine(MyMath.Abs(-32462311));



        }
    }
}
