using System;

namespace PolymorphismDemo;

class Class1
{
    //Virtual Function (Overridable Method)
    public virtual void Show()
    {
        //Parent Class Logic Same for All Child Classes
        Console.WriteLine("Parent Class Show Method");
    }
}
class Class2 : Class1
{
    //Overriding Method
    // public override void Show()
    // {
    //     //Child Class Reimplementing the Logic
    //     Console.WriteLine("Child Class Show Method");
    // } 
}
