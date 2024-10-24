using PolymorphismDemo;

// Method overloading inheritance based
Calculator2 obj = new Calculator2();
obj.Add(10, 20);
obj.Add(10.5f, 20.7f);
obj.Add("Lorem", "Ipsum");
Console.ReadKey();

// Constructor overloading
ConstructorOverloading obj1 = new ConstructorOverloading(10);
obj1.Display();
ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
obj2.Display();
ConstructorOverloading obj3 = new ConstructorOverloading(10, 20, 30);
obj3.Display();

// Method overriding 2
// The more detail explanation of this code can be found
// in this link: https://dotnettutorials.net/lesson/function-overriding-csharp/
Class1 obj4 = new Class2();
obj4.Show();

Class2 obj5 = new Class2();
obj5.Show();

// Method overriding : Advanced
Employee emp1 = new Developer
{
    Id = 1001,
    Name = "Ramesh",
    Salary = 500000,
    Designation = "Developer"
};
double bonus = emp1.CalculateBonus(emp1.Salary);
Console.WriteLine($"Name: {emp1.Name}, Designation: {emp1.Designation}, Salary: {emp1.Salary}, Bonus:{bonus}");
Console.WriteLine();
Employee emp2 = new Manager
{
    Id = 1002,
    Name = "Sachin",
    Salary = 800000,
    Designation = "Manager"
};
bonus = emp2.CalculateBonus(emp2.Salary);
Console.WriteLine($"Name: {emp2.Name}, Designation: {emp2.Designation}, Salary: {emp2.Salary}, Bonus:{bonus}");
Console.WriteLine();
Employee emp3 = new Admin
{
    Id = 1003,
    Name = "Rajib",
    Salary = 300000,
    Designation = "Admin"
};
bonus = emp3.CalculateBonus(emp3.Salary);
Console.WriteLine($"Name: {emp3.Name}, Designation: {emp3.Designation}, Salary: {emp3.Salary}, Bonus:{bonus}");
Console.WriteLine();
Employee emp4 = new Developer
{
    Id = 1004,
    Name = "Priyanka",
    Salary = 200000,
    Designation = "Developer"
};
bonus = emp1.CalculateBonus(emp4.Salary);
Console.WriteLine($"Name: {emp4.Name}, Designation: {emp4.Designation}, Salary: {emp4.Salary}, Bonus:{bonus}");