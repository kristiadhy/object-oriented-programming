using System;

namespace PolymorphismDemo;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Designation { get; set; }
    public double Salary { get; set; }
    public virtual double CalculateBonus(double Salary)
    {
        return 50000;
    }
}
public class Developer : Employee
{
    //50000 or 20% Bonus to Developers which is greater
    public override double CalculateBonus(double Salary)
    {
        double baseSalry = base.CalculateBonus(Salary);
        double calculatedSalary = Salary * .20;
        if (baseSalry >= calculatedSalary)
        {
            return baseSalry;
        }
            
        else
        {
            return calculatedSalary;
        }
    }
}
public class Manager : Employee
{
    //50000 or 25% Bonus to Developers which is greater
    public override double CalculateBonus(double Salary)
    {
        double baseSalry = base.CalculateBonus(Salary);
        double calculatedSalary = Salary * .25;
        if (baseSalry >= calculatedSalary)
        {
            return baseSalry;
        }
        else
        {
            return calculatedSalary;
        }
    }
}
public class Admin : Employee
{
    //return fixed bonus 50000
    //no need to overide the method
}
