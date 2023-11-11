using System;
namespace W3Schools_CSharp
{
	class Vehicle : Cars
	{
		// Why use inheritance? Allows for code reusability.
		// Polymorphism uses inhrited methods to perform different tasks.
		// If you do not want other methods to inherit from a class, use the sealed keyword.
		// We have the derived class, or child class and the base class, or parent class.
		// To inherit from a class, use the : symbol.
		// In this example, were going to inherit from the Cars class.

		public string modelName = "Lamborghini";



	}
}

