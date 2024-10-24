using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo;
public class Parent
{
    public void Display()
    {
        Console.WriteLine("This is the parent class");
    }
}

public class Child1 : Parent
{
    public void Show1()
    {
        Console.WriteLine("This is the first child class");
    }
}

public class Child2 : Parent
{
    public void Show2()
    {
        Console.WriteLine("This is the second child class");
    }
}