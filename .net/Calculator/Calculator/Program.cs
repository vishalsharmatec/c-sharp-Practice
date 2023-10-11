using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First Number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int result = 0;
            char op = Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case '+':
                    result = i + j;
                    break;
                case '-':
                    result = i - j;
                    break;
                case '*':
                    result = i * j;
                    break;
                case '/':
                    result = i / j;
                    break;
            }
            Console.ReadLine();
        }
    }
}
