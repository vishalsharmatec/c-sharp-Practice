using System;
public class esc1
{
    esc1()
    {
        Console.WriteLine("Default");

    }
    ~esc1()
    {
        Console.WriteLine("destructor");
    }
    public static void Main(String [] args)
    {
        esc1 e = new esc1();
        Console.ReadLine();
    }
}