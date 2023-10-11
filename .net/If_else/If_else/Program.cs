using System;

namespace If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Marks");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i>=75)
            {
                Console.WriteLine("A Grade");
            }
            else if(i>60 &&i<75)
            {
                Console.WriteLine("Grade B");

            }
            else
            {
                Console.WriteLine("Grade c");
            }
            Console.ReadLine();
        }
    }
}
