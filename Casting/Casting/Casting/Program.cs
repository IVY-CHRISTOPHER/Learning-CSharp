//implicit Conversion
int num = 12324242;
long bigNum = num;

float myFloat = 13.243f;
double myNewDouble = myFloat;

double mydouble = 3.1415;
int myInt;
// Explicit Conversion
// cast double to int;

myInt = (int)mydouble;

//typeConversion
string myString = mydouble.ToString(); //"3.1415"
string myFloatString = myFloat.ToString(); // "13.243"

Console.WriteLine(myInt);
Console.Read();
