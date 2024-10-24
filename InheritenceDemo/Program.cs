using InheritenceDemo;


// Single Inheritence
Dog myDog = new Dog();
myDog.Eat(); // Output: "Animal is eating."
myDog.Bark(); // Output: "Dog is barking."

// Multi-level Inheritence
Child child = new Child();
child.Display(); // Output: This is the grandfather class
child.Show(); // Output: This is the father class
child.DisplayChild(); // Output: This is the child class

// Hierarchical Inheritence
Child1 child1 = new Child1();
child1.Display(); // Output: This is the parent class
child1.Show1(); // Output: This is the first child class

Child2 child2 = new Child2();
child2.Display(); // Output: This is the parent class
child2.Show2(); // Output: This is the second child class