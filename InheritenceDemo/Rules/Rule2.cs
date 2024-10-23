// namespace InheritenceDemo.Rules;

// // Reference : https://dotnettutorials.net/lesson/inheritance-c-sharp/

// // We can Initialize a Parent class variable by using the child class instance to make it
// // a reference variable so that the reference will be consuming the memory of the child class instance.
// // But in this case, also, we cannot call any pure child class members using the reference.

// // In the below example, we have initialized the parent class reference variable p
// // using the child class instance and then called the parent class members. In the below example,
// // the Main method code is self-explained, so please go through the comment lines.
// class A
// {
//     public A()
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
//     public B()
//     {
//         Console.WriteLine("Class B Constructor is Called");
//     }
//     public void Method3()
//     {
//         Console.WriteLine("Method 3");
//     }
//     static void Main()
//     {
//         A p; // p is a variable of class A
//         B q = new B(); // q is an instance of Class B 

//         // We can initialize a Parent class variable using child class instance as follows
//         p = q; // now, p is a reference of parent class created by using child class instance

//         // Now you can call members of A class as follows
//         p.Method1();
//         p.Method2();

//         // We cannot call any pure child class members using the reference p
//         // p.Method3();
//         Console.ReadKey();
//     }
// }

