using System;

namespace PolymorphismDemo;

public class Animal
{
    // Virtual method in the base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Overriding the method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class Cat : Animal
{
    // Overriding the method in the derived class
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}