using System;

namespace AbstractionDemo;

public abstract class Bird
{
    public abstract void Fly();

    // This method has an implementation and can be used directly by child classes
    public void LayEggs()
    {
        Console.WriteLine("Laying eggs");
    }
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

