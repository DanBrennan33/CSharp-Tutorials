using System;

public class SimpleClass
{ }

public class Example
{
    public static void Main()
    {
        SimpleClass sc = new SimpleClass();
        Console.WriteLine(sc.ToString());
        Console.ReadKey();
    }
}