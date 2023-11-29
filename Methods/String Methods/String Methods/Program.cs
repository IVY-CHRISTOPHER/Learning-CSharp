//string is an object of the System.String class

//SubString(Int32) is used to get the Substring from the string starting from
// the specified index

//Example
string car = "car";
Console.WriteLine(car.Substring(1)); // returns "ar"

//ToLower() used to convert the string to lowercase
//Example
string tolower = "THIS IS AN ALL CAPS STRING";
Console.WriteLine(tolower.ToLower()); // return "this is an all caps string"

//ToUpper() used to conver the string to uppercase
//Example
string toupper = "this is an all lower case string";
Console.WriteLine(toupper.ToUpper()); // return "THIS IS AN ALL LOWER CASE STRING"

//Trim() used to trim all leading and trailing white spaces from the string
//Example
string trimmed = "    This is a trimmed string!    ";
Console.WriteLine(trimmed.Trim()); // returns "This is a trimmed string!"

//IndexOf(String) used to get the first occurrence of the string or charcter inside the string
//Example
string indexOf = "This is a Test String";
Console.WriteLine(indexOf.IndexOf("Test")); //returns 10

//String.IsNullOrWhiteSpace(string) returns true if the string is wither null or is blank else it returns false
//Example 
string blankString = " ";
Console.WriteLine(String.IsNullOrWhiteSpace(blankString)); //returns True

//String.Format used to insert the object or variable value inside of string
//Example
string name = "Chris";
Console.WriteLine(String.Format("My name is {0}", name)); // returns "My name is Chris"

