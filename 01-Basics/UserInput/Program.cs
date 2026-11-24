//Exercise 1

//Read the user's first name and last name, then display their full name.

Console.WriteLine("Enter your FirstName : ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter your LastName : ");
string lastName = Console.ReadLine();
Console.WriteLine($"Welocme {firstName} {lastName}");

// Exercise 2
// Accept two integers from the user and display their sum, difference, product and quotient.
Console.WriteLine("Enter Number1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Number2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine($"The Sum of Two Numbers is : {sum}");
int difference = num1 - num2;
Console.WriteLine("The Difference of Two Numbers is : " + difference);
int product = num1 * num2;
Console.WriteLine($"The Product of Two Numbers is : {product}");
int quotient = num1 / num2;
Console.WriteLine($"The Quotient of Two Numbers is : {quotient}");

//Exercise 3

//Accept an employee's name, employee ID, age and salary, then display all details.

Console.WriteLine("Enter your Name : ");
string employeeName = Console.ReadLine();
Console.WriteLine("Enter your Employee ID : ");
string employeeID = Console.ReadLine();
Console.WriteLine("Enter your Age : ");
int employeeAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your Salary : ");
decimal employeeSalary = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Employee Details:\nName: {employeeName}\nID: {employeeID}\nAge: {employeeAge}\nSalary: {employeeSalary}");

//Exercise 4

//Accept a number from the user and check whether it is a valid integer using TryParse().

Console.WriteLine("Enter a Number : ");
bool isNumberValid = int.TryParse(Console.ReadLine(), out int number);
if (isNumberValid)
{
    Console.WriteLine($"The number is valid: {number}");
}
else
{
    Console.WriteLine("The number is not valid.");
}


//Exercise 5

//Ask the user to press a key and display which key was pressed.
Console.WriteLine("Press any key: ");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine($"\nYou pressed: {keyInfo.Key}");
