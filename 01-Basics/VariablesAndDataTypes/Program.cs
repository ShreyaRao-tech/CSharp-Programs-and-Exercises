//Exercise 1

//Declare variables for your name, age, height, and whether you are a student.
string name = "Shreya";
int age = 26;
double height = 5.3;
bool isStudent = true;

//Exercise 2

//Declare variables for all the following types: int, long, float, double, decimal, char and bool.
int myInt = 10;
long myLong = 10000000000;
float myFloat = 3.14f;
double myDouble = 3.14159;
decimal myDecimal = 3.1415m;
char myChar = 'A';
bool myBool = true;

//Exercise 3

//Print all variables using string interpolation.
Console.WriteLine($"My name is {name}, I am {age} years old, my height is {height} feet, and it is {isStudent} that I am a student.");

//Exercise 4

//Create a constant for your birth year and print it.

const int birthYear = 2000;

//Exercise 5

//Calculate the total price of 3 products using variables and display it.
decimal rockPrice = 10.99m;
decimal paperPrice = 5.99m;
decimal scissorsPrice = 2.99m;
decimal totalPrice = rockPrice + paperPrice + scissorsPrice;
Console.WriteLine($"The total price of the products is {totalPrice}");
