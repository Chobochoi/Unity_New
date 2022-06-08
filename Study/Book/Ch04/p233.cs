using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch04
{
    internal class p233
    {
        class Program
        {
            class Student
            {
                public string name;
                public int age;
            }

            static void Main1(string[] args)
            {
                List<Student> list = new List<Student>();
                list.Add(new Student() { name = "가", age = 14 });
                list.Add(new Student() { name = "나", age = 16 });
                list.Add(new Student() { name = "다", age = 11 });
                list.Add(new Student() { name = "라", age = 19 });
                list.Add(new Student() { name = "마", age = 22 });

                foreach (var item in list)
                {
                    Console.WriteLine(item.name + " : " + item.age);
                }
            }



        }
    }
}
