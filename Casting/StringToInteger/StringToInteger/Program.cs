string myString = "15";
// Must be ONLY a number anything else with a number will result in an error
// Unless Try/Catch or TryParse is used.
string mySecondString = "13";
int num1 = Int32.Parse(myString);
int num2 = Int32.Parse(mySecondString);
int result = num1 + num2;

Console.WriteLine(result);

string stringForFloat = "0.85"; // datatype should be float

string stringForInt = "12345"; // datatype should be int

float myFloat = float.Parse(stringForFloat);
int myInt = Int32.Parse(stringForInt);

Console.WriteLine(myInt);
Console.WriteLine(myFloat);
