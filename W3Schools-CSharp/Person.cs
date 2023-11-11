using System;
namespace W3Schools_CSharp
{
	class Person
	{
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value;}

			// The Name property is associated with the name field
			// It is good practice to use the same name for the property and the field, just with an uppercase
			// The get method returns the value of the variable name
			// The set method assigns a value to the set variable. The value keyword represents a value we assign to the property.

			// Now we can use the Name property to access and update the private field of the Person class. See Program class
			// Automatic properties
			// C# provides a way to use shorthand properties, this way we don't have to define a field for the property. You only have to write get; and set; inside the property inside curly braces.
			// Encapsulation provides better control of class members, fields can be read-only using get or write only using set
			// Better data security.
			// We use void to specify that the method doesn't return a value.



		}
	}
}

