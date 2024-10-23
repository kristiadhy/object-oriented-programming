// namespace InheritenceDemo.Rules;

// // RULE 1:
// // In C#, the parent classes constructor must be accessible to the child class;
// // Otherwise, the inheritance would not be possible because when we create the child class object, 
// // first it goes and calls the parent class constructor so that the parent class variable
// // will be initialized and we can consume them under the child class.

// // As you can see in the code, the Class A constructor is private, so it is not accessible to Class B.
// // Now, if you try to run the code, you will get the compile-time error.

// class A
// {
//     A()
//     {
//         Console.WriteLine("Class A Constructor is Called");
//     }
//     public void Method1()
//     {
//         Console.WriteLine("Method 1");
//     }
//     public void Method2()
//     {
//         Console.WriteLine("Method 2");
//     }
// }

// class B : A
// {
//     B()
//     {
//         Console.WriteLine("Class B Constructor is Called");
//     }
//     public void Method3()
//     {
//         Console.WriteLine("Method 3");
//     }

//     static void Main()
//     {
//         B obj = new B();
//         obj.Method1();
//         obj.Method2();
//         obj.Method3();
//         Console.ReadKey();
//     }
// }