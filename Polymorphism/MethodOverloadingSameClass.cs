using System;

namespace PolymorphismDemo;

public class Calculator
{
    // Overloaded method with two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method with three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method with two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }
}
