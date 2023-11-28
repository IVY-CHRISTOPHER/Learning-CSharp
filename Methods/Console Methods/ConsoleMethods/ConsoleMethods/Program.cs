
Console.Write("Text Here");
// Will print Text Here
// Prints and Keeps the cursor on the same line

Console.WriteLine("Text Here");
// Will print Text Here
// Prints and puts the cursor on the next line

Console.Read();
//Takes a single input of type String and it returns the ASCII value of that input
//ASCII is American Standard Code for Information Interchange
/* Is an eight bit character code.
 * A = 01000001
 * 
 * there are 256 values
*/

Console.ReadLine();
//Takes a string or integer input of returns it as the Output value
// Allows user input

Console.ReadKey();
// Takes a single input of type string and it returns the Key Info
// Details about the key that was entered

// SAMPLE CODE

    //Console.WriteLine("Hello Welcome"); //prints text and jumps to next line

    //Console.Write("Hello"); // prints the text in the same line

    //Console.Write("Welcome"); 

    //Console.ReadKey();

    Console.Write("Enter a String and Press Enter:");
    string readinput = Console.ReadLine();
    Console.WriteLine("You have entered {0}",readinput);

    Console.WriteLine("Enter a String and Press Enter:");
    int asciiValue = Console.Read();
    Console.WriteLine("ASCII Value is {0}",asciiValue);
    Console.ReadKey();

