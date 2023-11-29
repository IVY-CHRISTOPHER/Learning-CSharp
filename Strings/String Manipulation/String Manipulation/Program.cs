// Define new vairables
int age = 20;
string name = "Chris";
string birthday = "02/27/2003";

// 1. String concatination
Console.WriteLine("String Concatination");
Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");

//2. String Formatting
//String formatting uses index
Console.WriteLine("String Formatting");
                          //Index 0 v / Index 1 v          Index 0 / Index 1
Console.WriteLine("Hello my name is {0}, I am {1} years old", name, age);
Console.WriteLine("My Birthday is on {0}", birthday);

//3. String interpolation
//string interpolation uses $ at the start which will allow us to write our
//variables like this {variable}
Console.WriteLine("String Interpolation");
Console.WriteLine($"Hello my name is {name}, I am {age} years old and my bithday is on {birthday}.");

//4. Verbatim Strings
// verbatim strings start with @ and tells the compiler to take the string
// literally and ignore any spaces and escape charcters like /n
Console.WriteLine("Verbatim String");
Console.WriteLine(@"Lorem /n ipsum dolor sit Sed fermentum dui turpis, 
ut congue neque blandit nec. Mauris interdum sapien in purus pretium mollis.
Nullam odio leo, vehicula nec tellus id");

//instead of using \\ to write file paths we can use verbatim strings to make
// it easier.
// if you remove the @ you will get an error because \U, \A and \D are not valid
// escape characters
Console.WriteLine(@"C:User\Admin\Dog Pictures\Dog1\Super CoolDog.png");