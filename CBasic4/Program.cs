﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
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

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            Product product = new Product();
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
