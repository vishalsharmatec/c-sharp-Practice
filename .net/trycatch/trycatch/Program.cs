using System;

public class program
{
    public static void Main(string [] args)
    {
        int i = 10;
        int j = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        try
        {
            result = i / j;

        }
        catch(Exception)
        {
            Console.WriteLine("divide by non is not allowed");
        }
        Console.WriteLine("Result :" + result);
        Console.ReadLine();

    }
}
