using System;

namespace InheritenceDemo.Rules;

class A
{
    public A(int number)
    {
        Console.WriteLine($"Class A Constructor is Called : {number}");
    }
    public void Method1()
    {
        Console.WriteLine("Method 1");
    }
    public void Method2()
    {
        Console.WriteLine("Method 2");
    }
}
// class B : A
// {
//     public B()
//     {
//         Console.WriteLine("Class B Constructor is Called");
//     }
//     public void Method3()
//     {
//         Console.WriteLine("Method 3");
//     }
//     static void Main()
//     {
//     B obj = new B();
//         Console.ReadKey();
//     }
// }


class B : A
{
    public B() : base(10)
    {
        Console.WriteLine("Class B Constructor is Called");
    }
    public void Method3()
    {
        Console.WriteLine("Method 3");
    }
    static void Main()
    {
        B obj = new B();
        Console.ReadKey();
    }
}