﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        string Var = "테스트";
        static void Main(string[] args)
        {
            var name = "강" + "은" + "별";
            Console.Write("개행이 안되는 녀석");
            Console.WriteLine("개행이 되는 녀석");

            var alpha = "알파";
            //var 273alpha = "숫자이름"; 불가능
            var 한글변수명 = "가능하다";
            //var 😁😁😁😚😚😚 = "이모지는 불가능";

            //대소문자 잘 알아두기
            //인라인 주석
            /*
             *여러줄 주석
             */

            // 출력
            Console.Write("개행이 안되는 출력");
            Console.WriteLine("");
            Console.WriteLine("개행이 되는 출력");

            Console.WriteLine(52); //C#은 기본 자료형이 정수
            // Arithmetic Operator + - * /
            Console.WriteLine(52 + 273);
            //Operator Priority
            Console.WriteLine(5 + 3 * 2);

            Console.WriteLine(10 / 5); // 정수/정수 = 정수
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            //Real Number (실수)
            Console.WriteLine(52.273);

            Console.WriteLine(0);
            Console.WriteLine(0.0);  //실수는 double이 기본형

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);

            
            Console.WriteLine(1.0 / 2.0); //실수
            Console.WriteLine(1 / 2);     //정수
            Console.WriteLine(1.0 / 2);   //실수
            Console.WriteLine(1 / 2.0);   //실수(실수의 범위가 넓음)

            Console.WriteLine('A');
            Console.WriteLine('가');
            //Console.WriteLine('AB'); 문자 Error
            Console.WriteLine("AB"); //문자열은 가능

            Console.WriteLine("미\t림여자정보\t과학고");
            Console.WriteLine("미림\t여자정보\t과학고");
            Console.WriteLine("미림여\t자정보\t과학고");
            Console.WriteLine("미림여자정보과학고\t안녕");
            Console.WriteLine("\\ 역슬래시 \n 엔터문자 \" 큰 따옴표");

            // 문자열 연결 연산자 Concatenation Operator
            Console.WriteLine("A" + "B");
            Console.WriteLine("A" + 1);
            Console.WriteLine(1 + "A");
            Console.WriteLine("1" + "1");
            Console.WriteLine('A' + 'B');
            Console.WriteLine('A' - 'B');
            //Console.WriteLine("A" - "B"); 에러남
            Console.WriteLine("안녕하세요!"[0]);
            Console.WriteLine("안녕하세요!"[1]);
            Console.WriteLine("안녕하세요!"[2]);
            Console.WriteLine("안녕하세요!"[3]);
            //Console.WriteLine("안녕하세요!"[100]);
            //Console.WriteLine("안녕하세요!"[-1]);

            Console.WriteLine(true);
            Console.WriteLine(false);

            //Comparison operator
            // == !- > < >= <=
            // => =< 에러남
            Console.WriteLine(62 < 273);

            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);

            Console.WriteLine(3 > DateTime.Now.Hour && DateTime.Now.Hour < 8);

            //Integer overflow
            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            double c = 52.263;
            char d = '아';

            // sizeof 연산자
            Console.WriteLine("int:" + sizeof(int));
            Console.WriteLine("long:" + sizeof(long));
            Console.WriteLine("float:" + sizeof(float));
            Console.WriteLine("double:" + sizeof(double));
            Console.WriteLine("char:" + sizeof(char));
            Console.WriteLine("bool:" + sizeof(bool));

            bool TrueOrFalse = true;


            int output = 0;
            output += 52;   //output = output + 52;
            output += 273;  
            output += 103;

            Console.WriteLine(output);

            output *= 2;
            Console.WriteLine(output);


            //문자열 관련 복합 대입 연산자
            string output2 = "Hello";
            output2 += "World";
            output2 += "!";
            Console.WriteLine(output2);


            //증감 연산자
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
            Console.WriteLine(number);


        }
    }
}
