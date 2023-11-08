namespace W3Schools_CSharp;
class Program
{
    static void Main(string[] args)
    {
        double myDouble = 9;
        int myInt = (int)myDouble;

        Console.WriteLine("Hello, World!");
        Console.WriteLine(myInt);

        // In this example, the user can input his or her username, which is stores in the variable userName().
        // Then, we print the value of the userName().

        Console.WriteLine("Enter username:");
        string userName = Console.ReadLine();
        Console.WriteLine("Your username is: " + userName);

        // Console.Realine() method returns a string so we would not be able to use int isntead of string when defining the userName variable.
        // You cannot implicitly convert type string to int
        // While true, we can convert type explicitly, in particular using Convert.ToString() method.

        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are " + age + " Years old.");
        Console.WriteLine(Math.Max(10, 5));
        Console.WriteLine(Math.Sqrt(144));
        Console.WriteLine(Math.Abs(-5));
        Console.WriteLine(Math.Round(9.44));

        string txt = "The quick brown fox jumped over the lazy dog";
        Console.WriteLine("The length of the above string is " + txt.Length);

        string name = "Kyle Nunn";
        Console.WriteLine($"My name is {name}");

        // We can find the exact position of a character within a string using the IndexOf() method.
        string address = "Hickoryview Drive";
        Console.WriteLine(address.IndexOf("o"));

        // SubString() method is commonly used with IndexOf() method.
        // It gets the index of and then displays a new string, a substring, from where that IndexOf() method starts.
        string newName = "John Doe";
        int posName = newName.IndexOf("D");
        string newLastName = newName.Substring(posName);
        Console.WriteLine(newLastName);


        // Because in C#, strings are written in quotes, "The quick brown "lion" jumped over the lazy dog" is just not going to work. But we can work around that.
        // The solution to avoid this problem, is the use the backslash escape character
        // The backslash escape character "\" turns special characters into string characters.
        // We can use \" \" which will allow a double quote within the string or \' \' which will create a single quote within the double quoted string.
        // Other notable escape characters \n for a new line \t for a tab and \b for a backspace
        // A boolean type can be called with the bool keyword
        // However, it is most common to return boolean values from boolean expressions for conditional testing.
        // Let's play with a real world example where we need to find out if a person is old enough to vote.

        int myAge = 25;
        int votingAge = 18;
        if (myAge >= votingAge)
        {
            Console.WriteLine("You are old enough to vote");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next year, kid.");
        }

        // All in all, for If.. Else statements we have if, else, else if , and switch
        // Short Hand if... else AKA Ternary Operator.
        // The ternary operator can used to write several lines of code into a single line.\
        // This is pretty cool
        // We could do something like this:

        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);

        // Using the switch statement to select one of the many code blocks to be executed.
        // Use the switch statement to execute one of the many code blocks to be executed.
        int month = 5;
        switch (month){
            case 1:
            Console.WriteLine("January");
            break;

            case 2:
            Console.WriteLine("February");
            break;
        }
        // The switch expression is evaluated once.
        // The value of the expression is compared with the values of each case
        // If there is a match, the associated block of code is executed.
        // We will also introduce break and default. Default, as you might have guessed on the default case in the swtich statement.

        // When C# reaches a break keyword, it breaks out of the swtich block.
        // This will stop the execution of more code and case testing within the block.
        // When a match is found and the job is done, it is time for a break. There is no more testing necessary.
        // A break can save alot of execution time becuase it ignores the rest of the code in the switch block.
        // The default keyword is optional and defines a default case to run if there is no match.

        // Example:
        int day = 4;
        switch(day){
            case 6:
                Console.WriteLine("Saturday");
                break;

            case 7:
                Console.WriteLine("Sunday");
                break;

            default:
                Console.WriteLine("Great Day");
                break;
        }

        // Lets check out a while loop. These are pretty cool.
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        // Its important to increase the value in the variable, ++, or the loop will never end and your webpage will run forever.
        // The do while loop is a variant of the while loop.
        // In the do/while loop, the loop will always be executed at least once, even if the condition is false, because the code block is executed before the condition is tested.
        // Example:

        int j = 0;
        do
        {
            Console.WriteLine(j);
            j++;
        }
        while (j < 5);
        // Don't forget to increase the variable in the expression or else the loop will never end.

        // Important
        // When you know exactly how many times you want to loop through a block of code, use for loop instead of while loop.
        // That's cool
        // There are three statements in a for loop:
        // Statement 1 is executed one time before the execution of the code block
        // Statement 2 defines the condition for executing the code block.
        // Statement 3 is executed everytime afte the code block has been executed.
        // Example: Only printing out even numbrs 0-10

        for (int k = 0; k <= 10; k = k + 2)
        {
            Console.WriteLine(k);
       
        }

        // Between the statements in the for loop, it's important that we use semi colons.
        // It's also possible to put one loop inside another loop. This is called a nested loop.
        // The inner loop will be executed one time for each iteration of the outer loop.
        // The inner loop will be executed one time for each iteration of the outer loop.

        // Example:
        // Outer loop
        for (int a = 1; a <= 2; ++a)
        {
            Console.WriteLine("Outer: " + a);

            for (int b = 1; b <= 3; b++)
            {
                Console.WriteLine("Inner: " + b);
            }
        }

        // The almighty Foreach loop
        // The foreach loop is used exlusively to loop through elements within an array
        // The following example outputs all elements in the cars array, using foreach loop

        string[] cars = { "VW", "LAMBO", "Rari" };
        foreach(string l in cars)
        {
            Console.WriteLine(l);
        }

        // Learning more about arrays. Coming up!
        // The break statement can be used to jump out of a switch statement and out of a for loop as well. Or any loop.
        // The following example jumps out of the loop when i = 4.
        for (int t = 0; t <= 10; t++)
        {
            if(t == 4)
            {
                break;
            }
            Console.WriteLine(t);
        }

        // The Continue statement
        // The continue statement break one iteration in the loop. 


    


    }
}

// Convert.To.Int32 is converting to an integer AND Convert.To.Int64 is long type integer.
// Floating point and double are paired up together while long, short, and int are paired up together.
// Console.ReadLine is used to get input while Console.WriteLine is used to show output.
// For example, the user can input his or username and we can store that in a variable.
// See that example in the UserInput class.
// Operators are used to perform operations on variables and values.
// The common operators are + - / * -- ++ || && 
// The $ sign is used for string interpolation
// The modulus, or %, basically just returns the remainder. So, if we did 9 % 3, the return would be 0.
// -- is decrement
// ++ is increment
// ! is a logical not.
// Comparison operators are used to compare two variables or values. This is important in programming as it helps us answer questions and make decisions.
// != is not equal to and will result in a boolean value returned.
// The C# math class has many methods that allows us to perform mathematicla operations on numbers.
// Math.Max(x,y) can be used to find the highest value of x and y
// Math.Min(x,y) can be used to find the lowest value of x and y.
// Math.Sqrt(x) returns the square root of x.
// Math.Abs(x) returns the absolute value of x
// Math.Round(x) round a number to the nearest whole number.
// A string in C# is actually an object.
// With can find the length of the string with variablename.Length
// Other string methods include ToUpper() and ToLower() which converts all characters in the string to either upper case or lower case.
// Adding two integers is called addition. Adding two strings is called concatenation. Programmers use this word becuase we like, or atleast they do, to feel good about themselves. Programming isn't hard, just some work.
// We can also use the string.Concat() method to concatenate two strings.
// Another option of string concatenation is string interpolation. We get to play with money here $$$$$$$. Realy only just one though.
// Access strings: We can access the chars in a string with square brackets








