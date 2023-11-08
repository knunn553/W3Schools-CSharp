using System;
namespace W3Schools_CSharp
{
	public class UserInput
	{
		static void Main1(string[] args)
		{
			// In this example, the user can input his or her username, which is stores in the variable userName().
			// Then, we print the value of the userName().

			Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();

			Console.WriteLine("Your username is: " + userName);

		}
	}
}

