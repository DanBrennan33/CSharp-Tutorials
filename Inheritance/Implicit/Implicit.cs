using System;
using System.Reflection;

public class SimpleClass
{ }

public class Example
{
	public static void Main(string[] args)
    {
        Type t = typeof(SimpleClass);
        BindingFlags flags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public |
                           BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
        MemberInfo[] members = t.GetMembers(flags);
        Console.WriteLine("Type {0} has {1} members: ", t.Name, members.Length);
        foreach (var member in members)
        {
            string access = "";
            string stat = "";
            var method = member as MethodBase;
            if (method != null)
            {
                if (method.IsPublic)
                    access = " Public";
                else if (method.IsPrivate)
                    access = " Private";
                else if (method.IsFamily)
                    access = " Protected";
                else if (method.IsAssembly)
                    access = " Internal";
                else if (method.IsFamilyOrAssembly)
                    access = " Protected Internal ";
                if (method.IsStatic)
                    stat = " Static";
            }
            Console.WriteLine("{0} ({1}): {2}{3}, Declared by {4}", member.Name, member.MemberType, access, stat, member.DeclaringType);
            
        }
    }
}

// The example displays the following output:
//	Type SimpleClass has 9 members:
//	ToString (Method):  Public, Declared by System.Object
//	Equals (Method):  Public, Declared by System.Object
//	Equals (Method):  Public Static, Declared by System.Object
//	ReferenceEquals (Method):  Public Static, Declared by System.Object
//	GetHashCode (Method):  Public, Declared by System.Object
//	GetType (Method):  Public, Declared by System.Object
//	Finalize (Method):  Internal, Declared by System.Object
//	MemberwiseClone (Method):  Internal, Declared by System.Object
//	.ctor (Constructor):  Public, Declared by SimpleClass
