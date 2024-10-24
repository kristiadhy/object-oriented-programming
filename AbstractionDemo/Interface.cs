using System;

namespace AbstractionDemo;

public interface ISpeakable
{
    void Speak();  // Interface method, must be implemented by any class
}

public interface IMoveable
{
    void Move();   // Another interface method
}

public class Dog : ISpeakable, IMoveable
{
    public void Speak()
    {
        Console.WriteLine("Bark");
    }

    public void Move()
    {
        Console.WriteLine("Dog is running");
    }
}
