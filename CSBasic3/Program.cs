using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 52, 172, 13, 13, 103 };
            intArray[2] = 0;
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(intArray.Length);

            int[] intArray2 = new int[1000];
            Console.WriteLine(intArray2[0]);
            Console.WriteLine(intArray2[999]);


            int i = 0;
            int[] intArray3 = { 52, 273, 32, 65, 103 };

            while(i < intArray3.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);

                i++;
            }

            string input;
            do
            {
                Console.Write("입력 (exit를 입력하면 종료) : ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("go 공지사항");
                        break;
                    case "2":
                        Console.WriteLine("go 오늘의 점심");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            } while (input != "exit");

            for (int i2 = '가'; i2 <= '힣'; i2++)
            {
                //Console.Write((char)i2);
            }

            for (int i3 = intArray3.Length -1; i3 >= 0; i3--)
            {
                Console.WriteLine(intArray3[i3]);
            }


            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach( string item in array)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.WriteLine("");
            }


            string inputString = "Potato Tomato";
            inputString.ToUpper();
            Console.WriteLine(inputString);
            Console.WriteLine(inputString.ToLower());
            Console.WriteLine(inputString);
            //C#에서 string관련된 함수들은 원본을 건들이지 않음        


            string foodString = "감자 고구마 피자 치킨";
            string[] foods = foodString.Split(new char[] { ' ' });
            foreach(var food in foods)
            {
                Console.WriteLine(food);
            }

            string pathString = "C:\\Python27;C:\\Python27\\Scripts;C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;C:\\jsp\\download\\app\\oracle\\product\\11.2.0\\server\\bin;C:\\Program Files (x86)\\Intel\\Intel(R) Management Engine Components\\iCLS\\;C:\\Program Files\\Intel\\Intel(R) Management Engine Components\\iCLS\\;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;C:\\Program Files (x86)\\Intel\\Intel(R) Management Engine Components\\DAL;C:\\Program Files\\Intel\\Intel(R) Management Engine Components\\DAL;C:\\Program Files\\Intel\\WiFi\\bin\\;C:\\Program Files\\Common Files\\Intel\\WirelessCommon\\;C:\\Program Files\\Java\\jdk1.8.0_241\\bin;\\Program Files\\Git\\cmd;C:\\Program Files\\Microsoft VS Code\\bin;C:\\Program Files\\Git\\cmd;C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin;C:\\Program Files\\nodejs\\;C:\\Program Files\\dotnet\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;C:\\Program Files (x86)\\dotnet\\;C:\\Program Files\\Docker\\Docker\\resources\\bin;C:\\ProgramData\\DockerDesktop\\version-bin;C:\\apache-cassandra-3.0.24\\bin;";
            string[] paths = pathString.Split(new char[] { ';' });
            foreach(var path in paths)
            {
                Console.WriteLine(path);
            }

            string StrangeInput = " test \n         \n";
            Console.WriteLine("[" + StrangeInput + "]");
            Console.WriteLine("[" + StrangeInput.Trim() + "]");

            string[] foodsArray = { "감자", "고구마", "피자", "치킨" };
            Console.WriteLine(string.Join(",", foodsArray));

            Console.Clear();
            Console.WriteLine("포맷 중 : 0% [_________]");
            for (int f = 0; f < 10; f++)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("포맷 중 : ");
                Console.Write((f + 1) * 10 + "% [");
                for (int f2 = 0; f2 < f + 1; f2++)
                    Console.Write("#");
                for (int f2 = f; f2 < 10; f2++)
                    Console.Write("_");
                Console.WriteLine("]");
                Thread.Sleep(1000);
            }
            Thread.Sleep(3000);

            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5); //(행,열)이 아니라 (열,행)임 헷갈리지 않기
                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(1000);
                x++;
            }

        }
    }
}
