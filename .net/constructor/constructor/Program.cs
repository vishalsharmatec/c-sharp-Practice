
// defaut const
/*using System;
public class program
{
    int i;
    program()
    {
        Console.WriteLine("Default Constructor");

    }
    public static void Main(string [] args)
    {
        program pr = new program();
        Console.ReadLine();

    }
}*/

// parameterized constructor
using System;
public class esc1
{
    esc1(int i, int j)
    {
        Console.WriteLine(i + j);

    }
    public static void Main(string [] args)
    {
  
        esc1 e2 = new esc1(22, 44);
        Console.ReadLine();

    }
}
