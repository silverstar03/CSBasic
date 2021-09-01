﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic8
{
    class Program
    {
        class Parent { }
        class Child : Parent, IDisposable, IComparable
        {
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
        class TestClass : IBasic
        {
            public int TestProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose () 메서드 호출!");
            }
        }
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                //return Price.CompareTo((obj as Product).Price);
                //return -1 * Price.CompareTo((obj as Product).Price); //역정렬
                return Name.CompareTo((obj as Product).Name);

            }

            public override string ToString()
            {
                return Name + ":" + Price + "원";
            }
        }
            static void Main(string[] args)
        {
            Child child = new Child();
            Parent childAsParent = new Child();
            IDisposable childAsDisposable = new Child();
            IComparable childAsCommparable = new Child();

            using (Dummy dummy = new Dummy())
            {

            }
            //Dummy dummy = new Dummy();
            //dummy.Dispose();

            List<Product> list = new List<Product>()
            {
                new Product () {Name="고구마", Price=1500},
                new Product () {Name="사과", Price=2400},
                new Product () {Name="바나나", Price=1000},
                new Product () {Name="배", Price=3000},
            };
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
