using System;

namespace Functiom
{
    class Program
    {
        public void m1()
        {
            Console.WriteLine("simple function");
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.m1();
            Console.ReadLine();
        }
    }
}
