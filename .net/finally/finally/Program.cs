using System;

public class esc1
{
    public static void Main(string [] args)
    {
        int i = 0;
        int j = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        try
        {
            result = i / j;

        }
        catch( Exception)
        {
            Console.WriteLine("divide by zero is not allowed");

        }
        finally
        {
            Console.WriteLine("Finally blocked");
        }
        Console.WriteLine("Result is :" + result);
        Console.ReadLine();
    }
}