using System;

namespace EncapsulationDemo;

public class BankDataEncapsulationUsingProperty
{
    // Or your can use property to encapsulate the data
    private double _balance;
    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    // -- Alternative way to write the property --
    // This is an AutoProperty (C# 3.0 and higher) - which is a shorthand syntax.
    // used to generate a private field for you
    public double Balance_AutoProp { get; set; }
}