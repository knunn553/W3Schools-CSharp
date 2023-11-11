using System;
namespace W3Schools_CSharp
{
	abstract class SportType
	{
		// Abstract method does not have a body
		public abstract void goalType();
		//{
		//	Console.WriteLine("The player scores");
		//}
		// Regular method
		public void sleep()
		{
			Console.WriteLine("Zzzz");
		}
	}

	class Baseball : SportType
	{
		public override void goalType()
		{
			Console.WriteLine("The player scores a run");
		}
	}

	class Football : SportType
	{
		public override void goalType()
		{
			Console.WriteLine("The player scores a touchdown");
		}
	}

	// Let's look at how these class interact through polymorphism in the program class main method.
	// The final output was not what we expected. This is because the base class method overrides the derived class method, when they share the same name.
	// C# provides an option to ovverride the base class method, by adding the virtual keyword to the method inside the base class and by using the override keyword for each derived class methods.

	// Abstract classes and methods are used to achieve security by hiding certain details and showing only important details of an object
	// Abstraction can only be achieved through interfaces.
	// Abstraction can be achieved either through absract classes or inferaces.
	// The abstract keywrod is used for classes and methods.
	// Abstract class is a restricted class that cannot be used to create objects. To access it, it must be inherited from another class.
	// Abstract method can only be used in an abstract class. It does not have a body. The body is provided by the derived, or inherited, class.
	// An abstract class can have both abstract and regular methods.
	// We are going to convert the class SportType to an abstract class.



}

