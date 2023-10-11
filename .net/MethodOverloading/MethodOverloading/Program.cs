using System;

namespace MethodOverloading
{
    class Program
    { 
        public void m1()
    {
        Console.WriteLine("Method without parameter");

    }
        public void m1(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.m1();
            pr.m1(5, 8);
            Console.ReadLine();
        }
    }
}
