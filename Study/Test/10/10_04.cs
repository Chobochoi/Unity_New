using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    class Human
    {
        private string name;
        private int age;

        public Human(string name, int age)
        {
            this.name=name;
            this.age=age;
        }

        protected void Hello()
        {
            Console.WriteLine("이름 : {0}",name);
            Console.WriteLine("나이 : {0}",age);
        }
    }
    class Student : Human
    {
        private int stundentId;

        public Student(string name, int age, int studentId): base(name, age)
        {
            this.stundentId = studentId;
        }

        public void Hello()
        {
            base.Hello();
            Console.WriteLine("학번 : {0}\n", stundentId);
        }
    }

    class Worker : Human
    {
        private int workerId;

        public Worker(string name, int age, int workId) : base(name, age)
        {
            this.workerId = workerId;
        }
        public void Hello()
        {
            base.Hello();
            Console.WriteLine("사번 : {0}\n", workerId);
        }
    }

    internal class _10_04
    {
        static void Main1(string[] args)
        {
            Student kim = new Student("김철수", 21, 20201234);
            Student lee = new Student("이철수", 35, 20211201);

            kim.Hello();
            lee.Hello();
        }
    }
}
