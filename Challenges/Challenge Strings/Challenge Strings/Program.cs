/*
Challenge 1 – String and its methods

Now you know the use of various string functions so let’s create a small Console application to practice this.

Declare a string variable and don’t assign any value to it.

Print on the console “Please enter your name and press enter”. You can then enter your name or any other valid string like “tutorials.eu”.

Assign that entered string to the string variable which you have declared initially.

The program should write on the console that string in Uppercase in the first line, then the same string in Lowercase in the second line. In the third line, it writes on the console the string with no trailing or preceding white space like if string entered as “ tutorials.eu ” it should be written on the console as “tutorials.eu”. And in the last line, it should write the Substring of the entered string on the console.

These kinds of features are e.g. used when creating a login screen, where the system will cut out trailing or preceding white space or, doesn’t care about the casing of the entered username.

*/


// ANSWER --

string myString;
Console.WriteLine("Please enter your name and press enter : ");
myString = Console.ReadLine();

Console.WriteLine("To Upper");
Console.WriteLine(myString.ToUpper());
Console.WriteLine("To Lower");
Console.WriteLine(myString.ToLower());
Console.WriteLine("Trimmed");
Console.WriteLine(myString.Trim());
Console.WriteLine("Substring of 1");
Console.WriteLine(myString.Substring(1));

/*
This application asks the user to input a string in the first line like “Enter a string here: ”.

In the Second Line, it should ask for the character to search in the string which you have entered in the first line like “Enter the character to search: ”

On the third line, it should write the index of the first occurrence of the searched character from the string.

Now on concatenation...

It should then ask to enter the first name and once the name is written and the enter button is pressed, it should ask to enter the last name.

It should then show your full name printed in a single line like in my case the output will be "Denis Panjuta". Output can be different in your case. Try to store the full name in a variable, before displaying it.
*/

string myString1;
string myChar;
Console.WriteLine("Please input a string: ");
myString1 = Console.ReadLine();
Console.WriteLine("Enter a Character to search: ");
myChar = Console.ReadLine();
Console.WriteLine(myString1.IndexOf(myChar));


string firstName;
string lastName;
string fullName;
Console.WriteLine("Please input first name: ");
firstName = Console.ReadLine();
Console.WriteLine("Please input last name: ");
lastName = Console.ReadLine();
fullName = firstName + " " +  lastName;
Console.WriteLine(fullName);