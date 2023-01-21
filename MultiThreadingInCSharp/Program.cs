using System;
using System.Threading;
using System.Xml.Serialization;

namespace MultiThreadingInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insingle threaded program methods executes one after the other
            Console.WriteLine("Multi Threading In C#");
            Test1();
            Test2();
            Test3();
        }
        public static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ": Running Test1 method");
            }
        }
        public static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ": Running Test2 method");
                if (i == 50)
                {
                    Console.WriteLine("Waiting for 5 secs");
                    Thread.Sleep(5000);
                } 
            }
        }
        public static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ":Running Test3 method");
            }
        }
    }
}
