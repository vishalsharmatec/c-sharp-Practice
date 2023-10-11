using System;

namespace functionParameter
{
    class Program
    {public int m1(int i, int j)
        {
            int result = i + j;
            Console.WriteLine(result);

            return result;
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            int ans = pr.m1(10, 5);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
