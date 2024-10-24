using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo;
public class Grandfather
{
    public void Display()
    {
        Console.WriteLine("This is the grandfather class");
    }
}

public class Father : Grandfather
{
    public void Show()
    {
        Console.WriteLine("This is the father class");
    }
}

public class Child : Father
{
    public void DisplayChild()
    {
        Console.WriteLine("This is the child class");
    }
}