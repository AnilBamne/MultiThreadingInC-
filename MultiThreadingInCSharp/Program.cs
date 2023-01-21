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
            //Test1();
            //Test2();
            //Test3();
            //In single threading all methods execute one by one 

            //-> Multi threading <-
            //defining threads
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            //calling threads
            t1.Start();
            t2.Start();
            t3.Start();
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
            }
        }
        public static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + ": Running Test3 method");
            }
        }
    }
}
