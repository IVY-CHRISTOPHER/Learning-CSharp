//Declaring a variable
int num1;
//assigning a value to a variable
num1 = 10;
// declaring multiple variables at once
int num3, num4, num5;

//Declaring and initalizing a variable in one go
int num2 = 23;
int sum = num1 + num2;

// using concatination
Console.WriteLine("Num1 is " +  num1);
Console.WriteLine("Num1 " + num1 + " + Num2 " + num2 + " is " + sum);

double d1 = 3.1415;
double d2 = 5.78;
double dDiv = d1 / d2;
Console.WriteLine("d1/d2 is " + dDiv);

float f1 = 3.1415f;
float f2 = 5.78f;
float fDiv = f1 / f2;
Console.WriteLine("f1/f2 is " + fDiv);

double diDiv = d1 / num1;
Console.WriteLine("d1/num1 is " + diDiv);

Console.WriteLine("-------------Strings------------");

string myName = "Chris";
string message = "My name is ";
string introduction = message + myName;
Console.WriteLine(message + myName);

string capsmessage = introduction.ToUpper();
Console.WriteLine(capsmessage);

Console.Read();
