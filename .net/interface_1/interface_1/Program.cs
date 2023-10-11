/*using System;

public interface A
{
    void m1();
}
class B : A
{
    public void m1()
    {
        Console.WriteLine("m1");

    }
}
class C
{
    public static void Main(string[] args)
    {
        B b = new B();
        b.m1();
        Console.ReadLine();

    }
}
*/
using System;
public interface A
{
    void m1();

}
public interface A1
{
    void m1();

}
class B : A, A1
{
    public void m1()
    {
        Console.WriteLine("m1");

    }
}
class C
{
    public static void Main(string[] args)
    {
        B b = new B();
        b.m1();
    }
}