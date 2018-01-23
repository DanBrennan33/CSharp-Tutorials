using System;

public class A
{
    private int value = 10;

    public virtual void Method1()
    {
        Console.WriteLine("A: Method1 Implementation.");
    }

    public int GetValue()
    {
        return this.value;
    }

    public class B : A
	{
        public int GetValue()
        {
            return this.value;
        }

        public override void Method1()
        {
            Console.WriteLine("B: Method1 Implementation.");
        }
	}
}

public class C : A
{
    // public int GetValue()
    // {
    //      return this.value;
    // }
}

public class Example
{
    public static void Main(string[] args)
    {
        var a = new A();
        var b = new A.B();
        Console.WriteLine("====== A ======");
        Console.WriteLine(a.GetValue());
        a.Method1();
        Console.WriteLine("====== B ======");
        Console.WriteLine(b.GetValue());
        b.Method1();
    }
}