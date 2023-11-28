
//Basic Data Types

int iAmANumber = 5;
// whole numbers from -2,147,483,647 to 2,147,483,647
double pi = 3.1415;
//allows decimals and an even higher range than the float
// most real world values (except money calculations)
bool isGPSEnabled = true;
// only allows two states true/false
string myName = "Chris";
//allows multuple letters and unicodes
//uses double quotes"
char at = '@';
// allows a single literal or unicode
//needs single quotes '

Console.WriteLine(iAmANumber);
// Output will be 5

// More Data Types
sbyte x = 120;
//sound byte
//whole numbers from -128 to 127

short y = 30000;
//whole numbers from -32767 to 32767

long z = 9000000000000;
//whole numbers from -9,223,327,036,854,775,808 to 9,223,327,036,854,775,808

//When to use them?
//use the smallest data type possible.

float a = 99.99f;
//Allows deciamls and a range from 1.5 x 10^-45 to 3.4 x 10^38
// needs to have the f or it will read it as a double
//used for high demands for processing powers

decimal b = 1.5M;
//allows decimals and an even higher range than the double
// mostly used in financial applications



iAmANumber = 20;
Console.WriteLine(iAmANumber);
//Output will be 20
Console.WriteLine(pi);
Console.WriteLine(isGPSEnabled);
Console.WriteLine(myName);
Console.WriteLine(at);

