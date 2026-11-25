//Exercise 1: Implicit conversion

//Declare an int variable and convert it into long, float and double. Print all values.

int num1 = 712;
long numlong = num1;
float numfloat = num1;
double numdouble = num1;
Console.WriteLine($"Integer num : {num1} \n LongNumber : {numlong} \n FloatNumber :{numfloat} \n DoubleNumber :{numdouble}");

//Declare a double variable with value 125.89 and convert it into int. Observe the output.

double num2 = 125.89;
int numint = (int)num2;
Console.WriteLine(numint);

//Convert a string containing a number into int, double and decimal using Convert methods.

string num3 = "123";
int stringtoint = Convert.ToInt32(num3);
double stringtodouble = Convert.ToDouble(num3);
decimal stringtodecimal = Convert.ToDecimal(num3);
Console.WriteLine($"original string : {num3} \n Integer : {stringtoint} \n Double : {stringtodouble} \n Decimal : {stringtodecimal}");

//Declare variables of type int, double and bool. Convert them into strings and print their values.

int Number1 = 123;
double Number2 = 456.789;
bool value = true;
string inttostring = Number1.ToString();
string doubletostring = Number2.ToString();
string booltostring = value.ToString();
Console.WriteLine($"{inttostring} ,{doubletostring} , {booltostring}");

//Declare a double variable with value 25.8. Convert it using both (int)and Convert.ToInt32().Compare the results.

double value1 = 25.8;
int value2 = (int)value1;
int value3 = Convert.ToInt32(value1);
Console.WriteLine($"original double value : {value1}\n using (int) : {value2}\n using Convert.ToInt32 :{value3}");

//Convert a char into its integer Unicode value and convert an integer character code back into char.

char character = 'S';
int chartoint = (int)character;
int unicodeValue = 86;
char inttochar = (Char)unicodeValue;
Console.WriteLine($"Charactervalue : {character} , UnicodeValue : {chartoint}");
Console.WriteLine($"unicodevalue : {unicodeValue} ,Charactervalue : {inttochar}");
