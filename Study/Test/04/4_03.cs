using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._04
{
    class Empolyee
    {
        public string Name { get; set; } = "홍길동";
        public string Position { get; set; } = "사원";

        public void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("이름 :"+Name);
            Console.WriteLine("직급 :"+Position);
            Console.WriteLine("----------------");
        }
    }
    
    internal class _4_03
    {
        static void Main1(string[] args)
        {
            Empolyee emp1 = new Empolyee();
            emp1.Show();
            Empolyee emp2 = new Empolyee();
            emp2.Name = "김유신";
            emp2.Position = "대리";
            emp2.Show();
            Empolyee emp3 = new Empolyee() 
            { Name = "김춘추", Position = "과장" };
            emp3.Show();

        }
    }
}
