objective : To understand how a C# application accepts input from users and converts that input into the required data types.

## Console.ReadLine()
->C# provides the Console class to interact with users through the console.
->Console.ReadLine() reads a line of input from the console.
ex:
Console.Write("Enter your name: ");
string name= Console.ReadLine();
Console.WriteLine("Hello, " + name);

Important points:
- Console.ReadLine() reads input until the user presses Enter.
- It returns a string (or null if the input stream ends).
- Even when the user enters a number, it is initially received as a string.

## Converting user input into other data types
Since Console.ReadLine() returns a string, we need to convert it when we want to perform calculations.

C# provides different conversion methods.

A. Parse()
Parse() converts a string into a specified data type.
Console.Write("Enter your age: ");

string? input = Console.ReadLine();

int age = int.Parse(input!);

Console.WriteLine($"Your age is {age}");

Important: Parse() throws an exception when the input cannot be converted.

For example, entering "abc" when expecting an integer causes a FormatException.

B. Convert
C# also provides the Convert class.
</>
string input = "100";

int number = Convert.ToInt32(input);

Console.WriteLine(number);
</>

C. TryParse()
A TryParse() attempts to convert a value without throwing a conversion exception for invalid input.

It returns:
- true if conversion succeeds.
- false if conversion fails.
</>
Console.Write("Enter your age: ");

string? input = Console.ReadLine();

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"Your age is {age}");
}
else
{
    Console.WriteLine("Please enter a valid number.");
}
</>

## Console.ReadKey()
reads a single key pressed by the user.

Unlike ReadLine(), it doesn't wait for the user to press Enter.

## Interview questions with answers

Q1. What does Console.ReadLine() return?

It returns a string containing the entered line, or null when the input stream ends.

Q2. What is the difference between Parse() and TryParse()?

Parse() returns the converted value or throws an exception on invalid input. TryParse() returns a Boolean indicating whether conversion succeeded and provides the converted value through an out parameter.

Q3. What is the difference between Convert.ToInt32() and int.Parse()?

Both can convert strings into integers. However, Convert.ToInt32(null) returns 0, whereas int.Parse(null) throws an ArgumentNullException. Both can throw exceptions for invalid numeric input.

Q4. Why is TryParse() preferred for user input?

Because user input is unpredictable. TryParse allows us to handle invalid input without relying on exceptions for normal validation.

Q5. What is the difference between Console.ReadLine() and Console.ReadKey()?

ReadLine reads a complete line until Enter is pressed. ReadKey reads one key press immediately.