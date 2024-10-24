namespace ClassAndObject;
// Here we use properties to define the state of the Car class
// We will discuss about this later.

// This is a class definition.
public class Car
{
    // This is an AutoProperty (C# 3.0 and higher) - which is a shorthand syntax.
    //used to generate a private field for you
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public void Drive()
    {
        Console.WriteLine("The car is driving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // This is an object of the Car class.
        Car myCar = new Car();
        myCar.Color = "White";
        myCar.Brand = "Honda";
        myCar.Model = "BRV";
        myCar.Drive(); // Output: "The car is driving."
    }
}