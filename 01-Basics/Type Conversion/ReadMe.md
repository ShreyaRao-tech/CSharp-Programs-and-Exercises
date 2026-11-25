Type Conversion in C#

1. What is type conversion?
Type conversion is the process of converting a value from one data type to another.

For example, converting an integer into a double or a string into an integer.

C# supports two fundamental types of conversions:
1. Implicit conversion
2. Explicit conversion

2. Implicit conversion
Implicit conversion happens automatically when converting from one data type to another compatible data type.

It generally happens when the conversion is safe and doesn't lose information.

Example:
int number = 100;

double result = number;

Console.WriteLine(result); //100
Here, C# automatically converts int into double.

3. Explicit conversion (Type Casting)
Explicit conversion is required when converting between types where information might be lost or the conversion isn't implicit.

We use the casting operator (dataType).
Example:
double price = 99.75;

int result = (int)price;

Console.WriteLine(result); //99

explicit conversions can cause data loss or overflow.

4.Type casting vs Convert.ToInt32()
double value = 15.8;

int a = (int)value;

int b = Convert.ToInt32(value);

Console.WriteLine(a);//15
Console.WriteLine(b);//16

Why?
- (int)value truncates the decimal portion.
- Convert.ToInt32(value) rounds to the nearest integer. For exact halfway values, it uses rounding to the nearest even integer.

5.Interview questions

Q1. What is type conversion in C#?

Type conversion is the process of converting a value from one data type to another. C# supports implicit and explicit conversions, along with conversion methods such as Convert and Parse.

Q2. What is the difference between implicit and explicit conversion?

Implicit conversion happens automatically when the conversion is supported without requiring an explicit cast. Explicit conversion requires the programmer to specify the target type using a casting operator and may result in data loss.

Q3. What is type casting?

Type casting is explicitly converting a value from one data type to another using the casting operator.

double value = 10.5;
int result = (int)value;

Q4. What is the difference between (int) and Convert.ToInt32()?

Casting truncates the fractional part, whereas Convert.ToInt32() rounds to the nearest integer, using midpoint-to-even rounding.

