using System;
using System.Runtime.ConstrainedExecution;

namespace W3Schools_CSharp
{
    class Cars
    {
        public string color = "silver";
        public int maxSpeed = 200;
        public string makeName = "Huracan";
        public void fullThrottle()

        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        // Why did we declare the fullThrottle() method as public and not static like in the examples from the C# methods chapter.
        // The static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.

        // We can also leave fields blank, and modify them when creating an object in the Main() method
        public string Make;
        public string Model;
        public int Year;


    }
       
}

// A program can only have one Main method. Plain and Simple.
// We don't have to create a main method in this class. We can have this class and use the fields and objects in the Main() method defined in the Program.cs class.
// You can create multiple objects of one class.
// One class has all the fields and methods, while the other class holds the Main() method (code to be executed)
// Did you notice the "public" keyword? This is an access modifier, which specified that the color variable/field of Cars is accessible for other classes as well, such as Program.cs.
// We will learn more about access modifiers and objects/classes in the next chapter.

// C# Class Members
// Fields and methods inside classes are oftne referred to as class members.
// Methods are just like JavaScript functions.
// We run methods when something is happening, such as when the dashboard says "The car is going as fast as it can!"

// We learned from the C# Methods chapter that methods are used to perform certain actions
// Methods normally belong to a class, and they define how an object of a class behaves.

// As I continue to read, I will learn more about other class members such as constructors and properties.
// In C#, a constructor is a special method that is used to initialize objects. The advantage of a constructor is that it is called when an object of a class is created.










