using System;

namespace CallByValue
{
    class Program
    {
         public void m1(int val)
        {
            val = val + 10;
            Console.WriteLine("value is the called function is :" + val);
        }
        static void Main(string[] args)
        {
            int val = 15;
            Program pr = new Program();
            Console.WriteLine("value before calling the function :" + val);
            pr.m1(val);
            Console.WriteLine("value before calling the function :" + val);
            Console.ReadLine();
          
        }
    }
}
