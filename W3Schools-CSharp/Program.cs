using System.Linq;
using System;
using System.Runtime.ConstrainedExecution;

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
        switch (month)
        {
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
        switch (day)
        {
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
        foreach (string l in cars)
        {
            Console.WriteLine(l);
        }

        // Learning more about arrays. Coming up!
        // The break statement can be used to jump out of a switch statement and out of a for loop as well. Or any loop.
        // The following example jumps out of the loop when t = 4.
        for (int t = 0; t <= 10; t++)
        {
            if (t == 4)
            {
                break;
            }
            Console.WriteLine(t);
        }

        // The Continue statement
        // The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the remaining loop interations.
        // This example skips the value of 4:
        for (int q = 0; q <= 10; q++)
        {
            if (q == 4)
            {
                continue;
            }
            Console.WriteLine(q);
        }

        // We can also have a break and continue in a while loop, not just a for loop.
        // Break example in While Loop
        int w = 0;
        while (w < 10)
        {
            Console.WriteLine(w);
            w++;
            if (w == 4)
            {
                break;
            }
        }
        // C# Arrays
        // Creating arrays
        // Arrays are used to store multiple values in a single variable, instead of declaring seperate variables for each value.
        // To declare an array, we define the variable with the squares bracket.
        string[] seasons = { "Winter", "Spring", "Summer", "Fall" };

        // To create an array of integers, we'd write:
        int[] myNums = { 1, 2, 3, 4, 5 };

        // Changing an array element:
        seasons[3] = "Baseball Season";

        // It is important to note that if we declare an array and initialize it later, we have to use the new keyword.
        // We can loop through an array!! Isn't that exciting!?
        // We can loop through the array with a for loop and then use the Length property to specify how many times the loop is run.
        // The following example outputs all elements in the seasons array:
        for (int u = 0; u < seasons.Length; u++)
        {
            Console.WriteLine(seasons[u]);
        }

        // The foreach loop is used exclusively to loop through elements in an array. Can be integers or string. Elements in general for arrays.
        foreach (string g in seasons)
        {
            Console.WriteLine(g);
        }

        // Sort is another array method.
        Array.Sort(seasons);
        foreach (string h in seasons)
        {
            Console.WriteLine(h);
        }

        // Other useful namespaces such as Min, Max, and Sum can be found in the System.Linq namespace
        // For including namespaces, we need to put "using System.Linq" at the beginning of the cs class

        int[] lotterynumbers = { 23, 34, 07, 02, 52 };
        Console.WriteLine(lotterynumbers.Max());
        Console.WriteLine(lotterynumbers.Sum());
        // We will learn more about other namespaces in other chapters.

        //Multidimensional arrays
        // In the last chapter, we learned about single dimensional arrays, also known as arrays. These are great, and something you will use alot while programming in C#.
        // However, if we want to store data in a tabular form, like a table with rows and columns, one needs to get familiar with multidimensional arrays.
        // A multidimensional array is basically an array of arrays.
        // Arrays can any number of dimensions. The most common are two dimensional arrays.
        // int[,] would specify the delaration of a two dimensional array and int[,,] would specify the decleration of a three dimensional array. Woah!
        // Example of two dimensional array:

        int[,] coolnumbers = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

        // Coolnumbers is now an array with two individual arrays as its elements. With that being said, the first and second arrays within the coolnumbers array have elements of there own and those elements are the numbers.
        // Accessing elements of a 2-D array
        // To access elements of a two dimensional array, we must specify two indexes, one for the array and one for the element within that array that is within the coolnumbers array.
        // Let's get that 7 number in the second element within the main array:
        Console.WriteLine(coolnumbers[1, 2]);
        // The same principles applies to changin the value of an elements inside of an array within an array.
        // We can easily loop through the elements in an array with the foreach loop
        // We can also use a for loop
        // For multidimensional arrays, we need one loop for each of the arrays dimensions
        // Also, we have to use GetLength() method instead of Length() to specify how many times to loops should run.

        // C# Methods
        // A method is a block of code that only runs when it is called
        // You can pass data, known as parameters, into a method.
        // Methods are used to perform certain actions and are also known as functions.
        // Methods allow better scalability and code reusability
        // A method is defined with a name of the method, followed by parenthesis. We already know of the Main() method which is predefined by C#
        // We can define our own methods to perform certain actions.
        // Let's create a method inside the program class that we are already in.
        // MyMethod

        MyMethod();

        NameMethod("Kyle");
        NameMethod("Ted");
        NameMethod("Stephanie");
        NameMethod("Sammy");
        NameMethod();


        int zz = ReturnMethod(2, 4);
        Console.WriteLine(zz);

        // Method overloading
        int myNum1 = PlusMethod(4, 5);
        double myNum2 = PlusMethod(9, 8);
        Console.WriteLine(myNum1);
        Console.WriteLine(myNum2);


        // Looking at the Cars class from another file.
        Cars myObj = new Cars();
        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.maxSpeed);


        Cars VWJetta = new Cars();
        VWJetta.Make = "Volkswagon";
        VWJetta.Model = "Jetta";
        VWJetta.Year = 2006;


        Cars FordMustang = new Cars();
        FordMustang.Make = "Ford";
        FordMustang.Model = "Mustang";
        FordMustang.Year = 2013;

        Console.WriteLine(VWJetta.Year);
        Console.WriteLine(FordMustang.Year);
        myObj.fullThrottle();

        Sports Baseball = new Sports("Yankees");         // Creating an object of the Sports class, which will call the constructor.
        Console.WriteLine(Baseball.model); // Print the value of model

        // The constructor name must match the class name and it can't have the return type of void or int.
        // The constructor is called when the object is created.
        // All classes have constructors by default. If I do not create one, C# creates one for me. However, then I'm not able to set values for fields.
        // In the end, constructors save time, following the DRY principle of programming.
        // Constructors can also take parameters, which are used to initialize fields.
        // Just like other methods, constructors can be overloaded by using different number of parameters.


        // Access Modifier
        // One of the most common access modifiers is Public, which we have seen extensively throughout the course.
        // C# access modifiers include public private protected and internal
        // Public: code is accessible by all classes
        // Private: code is only accessible within the same class
        // Protected: The code is accessible within the same class, or within a class inherited from that class.
        // Internal: The code is only accessible within its own assembly, but not from another assembly. I will learn more about assemblies in another chapter.
        // Protected internal and private protected are also two combinations of access modifiers
        // Access modifiers are used to achieve Encapsulation - which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private.
        // By default, all members of a class are private if I don't specify an access modifier.


        // C# Properties (Get and Set)
        // To achieve encapsulation, I must declare fields/values as private and provide public get and set methods to access and manipulate the value of a private field.
        // A property is like a combination of a variable and method and it has two methods, get and set.


        // Looking at encapsulation. Example found in the Person class.
        Person miObj = new Person();
        miObj.Name = "Kyle";
        Console.WriteLine(miObj.Name);

        // Looking at inheritance between the Vehicle and Cars classes.
        Vehicle newVehicle = new Vehicle();
        Console.WriteLine(newVehicle.makeName + " " + newVehicle.modelName);

        // Polymorphism means "many forms."
        // Polymorphism occurs when we have many classes connected to eachother through inheritance.
        // Inheritance lets us access methods and fields from another class.
        // Polymorphism uses those methods to perform different tasks.
        // This allows us to perform a single action in different way.
        // Take an athlete, for example. A sports player performs different actions depending on their sport. A football player scores a touchdown. Basketball player scores a goal. Baseball scores a run.

        //SportType newSport = new SportType();
        SportType newBaseball = new Baseball();
        SportType newFootball = new Football();

        //newSport.goalType();
        newBaseball.goalType();
        newFootball.goalType();
        newBaseball.sleep();

    }

    static void MyMethod()
    {
        // myMethod is the name of the method.
        // static means that the method belongs to the program class rather than belonging to an object of the program class. Static means the method belongs to the program class.
        // We will learn more about objects and how to access methods through objects later in this tutorial.
        // void means that this method does not have a return value. I will learn mor about return values later in this chapter.
        // In C#, begin methods with an uppercase letter. e.g. MyMethod(). We will do that in the future.
        // You can define a method and you can call a method. You can probably do more with a method, but I haven't come across an instance where you can just yet. Call and define are different.
        // Execute and calling a method are the same.
        // To execute a method, type the method myMethod followed by parenthesis and a semicolon:

        Console.WriteLine("This is the method is just created. I just got executed. The good kind of execution.");

        // A method can be called multiple times.
        // Method Parameters
        // Parameters and Arguments
        // Information can be passed to methods as a parameter. Parameters act as variables inside of a method.
        // Parameters are specified after the method name inside of the paranthesis.
        // I can add as many parameters as I want, I just need to seperate them with a comma.
        // The following method has a string called fname as a parameter.
    }


    static void NameMethod(string fname = "Person")
    {
        Console.WriteLine(fname + "Nunn");
        // We are calling this method, or executing this method, above in the Main section
        // When a parameters is passed in a method, we call that the argument.
        // So, in the above example, fname is the parameter and "Kyle", "Ted", etc are the arguments.
        // C# Default Parameter Value
        // I can also use default parameter value using the = sign.
        // For example, we will use a default parameter if nothing is called of = Person
        // A method with a default parameter is also known as an optional parameter.
        // The void keyword when calling a method indicates that the method should not return a value.
        // If we want to method to return a value, we can use a primitive data type such as double or int and put "return" inside the method that we are defining
        // This means the return goes inside the curly brackets. We aren't putting return in the parameters area with a method.
        // It is often good practice to store a result in a variable, it makes the code easier to read and maintain especially if a future user wants to get their hands on some legacy code.

    }

    static int ReturnMethod(int xx, int yy)
    {
        return xx + yy;
        // We will call this method and define a variable for it in the above main method area.
    }

    // Named Arguments
    // It is also possible to send arguments via the key: value syntax.
    // This way, the order of arguments does not matter.

    static void KidsMethod(string kid1, string kid2, string kid3)
    {
        Console.WriteLine("The youngest child is: " + kid3);
    }

    // C# Method overloading
    // With method overloading, multiple methods can have the same name with different parameters
    // Instead of defining two methods that do the same thing, it is better to overload one and define the method with different types.
    // Example. We will overload the PlusMethod method with two integer types: int and double
    static int PlusMethod(int cc, int vv)
    {
        return cc + vv;
    }
    static double PlusMethod(double nn, double mm)
    {
        return nn + mm;
    }

    // We have object oriented programming and procedural programming
    // Procedural is about writing procedures or methods that perform operations on the data.
    // Object oriented programming is about creating objects that contain both data and methods.
    // In OOP, there are classes and objects. Kyle is the class, ears, nose, and eyebrows are the objects.
    // A class is a template for an object and the object is an instance of a class.
    // In real life, a car is an object with attributes height and weight and methods of brake and drive.
    // A class is like an object instructor, or a blueprint for creating objects.
    // It is common practice to name the file and class the same thing.
    // An object is creating from a class.
    // Creating a class car and an object car
    // Looking into the Truck class from the very top of the page.

    // Below we will use the class Car which is in a different file.
    // This procedure can be seen towards the top in the Main() method of the class Program.
    
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








