using System;

namespace Abstract
{
    public abstract class Program
    {
        public abstract void m1();
        public void m2()
        {
            Console.WriteLine("m2");

        }
        class B:Program
        {
            public override void m1()
            {
                Console.WriteLine("m1");
            }
        }
        class c
        {

        }
        static void Main(string[] args)
        {
            Program pr = new B();
            pr.m1();
            pr.m2();
            Console.ReadLine();
           
        }
    }
}
