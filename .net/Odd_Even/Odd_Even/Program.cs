using System;

namespace Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of test");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine("It is Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadLine();
        }
    }
}
