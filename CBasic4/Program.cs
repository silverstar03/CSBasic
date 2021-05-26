using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class MyMath
    {
        public static double PI = 3.141592;
        public static void Hello()
        {
            Console.WriteLine("Greeting");
        }
    }
    class Product
    {
        public string name = "default";
        public int price = 1000;

        public override string ToString()
        {
            return this.name + " / " + this.price;
        }
    }
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        //클래스 이름 충돌!
        /*class Math
        {

        }*/

        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next()); //int형 범위 내에서
            Console.WriteLine(random.Next(100)); //0 ~ 99
            Console.WriteLine(random.Next(10, 100)); // 10이상 100미만(10~99)

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*100);
            Console.WriteLine();

            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            foreach (var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "\t item: " + item);
            }
            list.Remove(52);
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "\t item: " + item);
                //list.Remove(item);
            }

            Console.WriteLine();
            Console.WriteLine(Math.Abs(-52273));        //52273
            Console.WriteLine(Math.Ceiling(52.273));    //53
            Console.WriteLine(Math.Floor(52.273));      //32
            Console.WriteLine(Math.Max(52, 273));       //273
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            Product product = new Product();
            Console.WriteLine("\n" + product);
            Product productA = new Product() { name = "감자", price = 2000 };
            Console.WriteLine(productA);
            Product productB = new Product() { name = "고구마", price = 3000 };
            Console.WriteLine(productB + "\n");

            Console.WriteLine(MyMath.PI);
            MyMath.Hello();

            /*List<Student> students = new List<Student>();
            //필요한 멤버변수만 값을 설정할 수 있다.
            students.Add(new Student() { name = "윤인성", grade = 1 });
            students.Add(new Student() { name = "연하진", grade = 2 });
            students.Add(new Student() { name = "윤아린", grade = 3 });
            students.Add(new Student() { name = "윤명월", grade = 4 });
            students.Add(new Student() { name = "구지연", grade = 1 });
            students.Add(new Student() { name = "김연화", grade = 2 });
            students.Add(new Student() { name = "함기훈", favorityFood="밀크티"});*/

            List<Student> students = new List<Student>() {
                new Student() { name = "윤인성", grade = 1 },
                new Student() { name = "연하진", grade = 2 },
                new Student() { name = "윤아린", grade = 3 },
                new Student() { name = "윤명월", grade = 4 },
                new Student() { name = "구지연", grade = 1 },
                new Student() { name = "김연화", grade = 2 },
                new Student() { name = "함기훈", favorityFood = "밀크티" }
            };
            
        }
    }

    class FristClass
    {

    }

    class SecondClass
    {
        class ChildClass //클래스 안에 클래스 넣기 가능
        {

        }
    }
}
