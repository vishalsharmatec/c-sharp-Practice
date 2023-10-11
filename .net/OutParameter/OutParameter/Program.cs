using System;

namespace OutParameter
{
    class Program
    {
        public void m1(out int i)
        {
            i = 5;
            i = i + 5;

        }
        static void Main(string[] args)
        {
            int i = 6;
            Program pr = new Program();
            Console.WriteLine("Before calling the function ");
            pr.m1(out i);
            Console.WriteLine("After calling the function ");
            Console.ReadLine();
          
        }
    }
}
