# Variables and Data Types in C#

## 1. Introduction

A variable is a named memory location used to store data that can be accessed and modified during program execution.

### Syntax

```
dataType variableName = value;
```

Example:

```
int age = 25;
string name = "John";
```

## 2. Data Types in C#

Data types specify the type of data a variable can store.

### 2.1 Value Types

Value types store their values directly.

Examples:
- int
- long
- float
- double
- decimal
- char
- bool
- struct
- enum

### 2.2 Reference Types

Reference types store references to objects.

Examples:
- string
- object
- class
- interface
- array
- delegate

## 3. Difference Between Value Types and Reference Types

| Value Types | Reference Types |
|---|---|
| Store values directly | Store object references |
| Assignment copies the value | Assignment copies the reference |
| Examples: int, bool | Examples: string, class |

## 4. Important Concepts

### Variables
Named storage locations used to hold data.

### Constants
Values that cannot be changed after declaration.

```
const double PI = 3.14159;
```

### Type Inference
The compiler determines the variable type using `var`.

```
var age = 25;
```

## 5. float vs double vs decimal

| Type | Precision | Usage |
|---|---|---|
| float | ~6–9 digits | Graphics |
| double | ~15–17 digits | General calculations |
| decimal | ~28–29 digits | Financial calculations |


## 6. Interview Questions

1. What is a variable?
Ans : A variable is a named memory allocation used to store data that can be accessed and modified.

2. What are value types and reference types?
Ans : ValueTypes : stores the actual values. when assigned to other variable , the value is copied

int a = 10;
int b = a;
Console.WriteLine(a); ---> 10
Console.WriteLine(b);----->10
b=20;
Console.WriteLine(a); ---> 10
Console.WriteLine(b);----->20
Changing b doesnt affect a.

ReferenceTypes : stores the reference to objects. when asigned to other variable, reference is copied
int[] arr1={10,20,30};
int[] arr2=arr1;
arr2[0] = 40;
Console.WriteLine(arr1[0]);--->40
Console.WriteLine(arr2[0]);--->40
Both variables refer to the same array object.changing one array elements, affect the other array as well
Reference types include string, arrays, classes and interfaces.

3. Difference between float, double and decimal?
 All three are used to represent numbers with fractional parts, but they differ in precision and representation.
Data type	Size	Approximate precision
float	4 bytes	6–9 digits
double	8 bytes	15–17 digits
decimal	16 bytes	28–29 digits

4. Difference between var and dynamic?
Both allow you to declare variables without explicitly specifying their types, but they behave differently.

var:
- Type is determined by the compiler at compile time.
- Once inferred, the type cannot change.
- Must be initialized during declaration.
var age = 25;

// age is inferred as int
// age = "Shreya"; // Compilation error


dynamic:
- Type checking and member binding happen at runtime.
- Can hold values of different types.
- Errors involving invalid operations may occur at runtime.
dynamic value = 25;

value = "Shreya";

value = true;


var	                                                     dynamic
Compile-time type                                      inference	Runtime binding
Statically typed	                                   Dynamically typed
Type cannot change	                                   Can hold different types
Errors often caught at compile time	                   Some errors occur at runtime

5. Difference between const and readonly?
 const creates a compile-time constant whose value is fixed when declared, while readonly creates a runtime constant whose value can be set when declared or inside a constructor
Const: The value of a const variable is set at compile time and cannot be changed. It is implicitly static and must be initialized at the time of declaration.
const double PI = 3.14159;
const int MAX_VALUE ; ## Error: const variable must be initialized at declaration
Readonly: The value of a readonly variable can be set at runtime, either in the declaration or in the constructor of the class. It cannot be changed after that.
class Employee
{
    public readonly int employeeId;

    public Employee(int id)
    {
        employeeId = id;
    }
}
## 7. Practice Exercises

1.Declare variables for your name, age, height, and whether you are a student.
2.Declare variables for all the following types: int, long, float, double, decimal, char and bool.
3.Print all variables using string interpolation.
4.Create a constant for your birth year and print it.
5.Calculate the total price of 3 products using variables and display it.

---
