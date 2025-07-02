using StringManipulation;

class Program
{
    static void Main()
    {
        // Exercise 1: Count the number of characters in a string.
        Console.WriteLine($"Exercise 1: {StringFunctions.CountCharactersInString("Hello, World!")}");  // Output: 10

        // Exercise 2: Convert a string to uppercase.
        Console.WriteLine($"Exercise 2: {StringFunctions.ConvertToUpperCase("hello World")}");         // Output: HELLO WORLD

        // Exercise 3: Convert a string to lowercase.
        Console.WriteLine($"Exercise 3: {StringFunctions.ConvertToLowerCase("HELLO")}");               // Output: hello

        // Exercise 4: Check if a string starts with a given prefix.
        Console.WriteLine($"Exercise 4: {StringFunctions.CheckStartPrefix("Welcome", "wel")}");        // Output: True

        // Exercise 5: Check if a string ends with a given suffix.
        Console.WriteLine($"Exercise 5: {StringFunctions.CheckEndPrefix("file.txt", ".txt")}");        // Output: True

        // Exercise 6: Check if a string contains only digits.
        Console.WriteLine($"Exercise 6: {StringFunctions.CheckDigit("12345s")}");                      // Output: False
    }
}