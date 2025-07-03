class Program
{
    static void Main()
    {
        // Exercise 1: Count the number of characters in a string.
        Console.WriteLine($"Exercise 1: {StringFunctions.CountCharactersInString("Hello, World!")}");               // Output: 10

        // Exercise 2: Convert a string to uppercase.
        Console.WriteLine($"Exercise 2: {StringFunctions.ConvertToUpperCase("hello World")}");                      // Output: HELLO WORLD

        // Exercise 3: Convert a string to lowercase.
        Console.WriteLine($"Exercise 3: {StringFunctions.ConvertToLowerCase("HELLO")}");                            // Output: hello

        // Exercise 4: Check if a string starts with a given prefix.
        Console.WriteLine($"Exercise 4: {StringFunctions.CheckStartPrefix("Welcome", "wel")}");                     // Output: True

        // Exercise 5: Check if a string ends with a given suffix.
        Console.WriteLine($"Exercise 5: {StringFunctions.CheckEndPrefix("file.txt", ".txt")}");                     // Output: True

        // Exercise 6: Check if a string contains only digits.
        Console.WriteLine($"Exercise 6: {StringFunctions.CheckDigit("12345s")}");                                   // Output: False

        // Exercise 7: Check if a string contains only letters.
        Console.WriteLine($"Exercise 7: {StringFunctions.CheckLetter("hello")}");                                   // Output: False

        // Exercise 8: Capitalize the first character of a string.
        Console.WriteLine($"Exercise 8: {StringFunctions.Capitalize("hello")}");                                    // Output: Hello

        // Exercise 9: Swap the case of each character in a string.
        Console.WriteLine($"Exercise 9: {StringFunctions.SwapLettersCases("gRadE")}");                              // Output: GrADe

        // Exercise 10: Split a string into words. 
        Console.WriteLine($"Exercise 10: {string.Join(", ", StringFunctions.SplitString("hello world"))}");         // Output: hello, world

        // Exercise 11: Join a list of words into a string.
        Console.WriteLine($"Exercise 11: {StringFunctions.ConcatWords(["hello", "world"])}");                       // Output: hello world

        // Exercise 12: Remove leading and trailing whitespace from a string. 
        Console.WriteLine($"Exercise 12: |{StringFunctions.TrimWhitespaces("  hello world   ")}|");                 // Output: |hello world|

        // Exercise 13: Count the number of spaces in a string.
        Console.WriteLine($"Exercise 13: {StringFunctions.CountSpaces("hello   world")}");                          // Output: 3

        // Exercise 14: Check if a string is an email address format.
        Console.WriteLine($"Exercise 14: {StringFunctions.IsEmail("user@email.com")}");                             // Output: True

        // Exercise 15: Get the first 5 characters of a string.
        Console.WriteLine($"Exercise 15: {StringFunctions.FirstFiveCharacters("abcdefg")}");                        // Output: abcde

        // Exercise 16: Get the last 3 characters of a string.
        Console.WriteLine($"Exercise 16: {StringFunctions.LastThreeCharacters("abcd")}");                           // Output: bcd

        // Exercise 17: Replace commas with semicolons in a string.
        Console.WriteLine($"Exercise 17: {StringFunctions.ChangeCommaToSemicolon("a,b,c")}");                       // Output: a;b;c

        // Exercise 18: Check if two strings are anagrams. 
        Console.WriteLine($"Exercise 18: {StringFunctions.AreAnagrams("listen", "silent")}");                       // Output: True

        // Exercise 19: Find all the digits in a string.
        Console.WriteLine($"Exercise 19: {string.Join(", ", StringFunctions.GetDigitsFromString("a1b2c3"))}");      // Output: 1, 2, 3

        // Exercise 20: Find all the letters in a string.
        Console.WriteLine($"Exercise 20: [{string.Join(", ", StringFunctions.GetLettersInString("abc123"))}]");     // Output: a, b, c

        // Exercise 21: Mask an email address (e.g., a***@domain.com).
        Console.WriteLine($"Exercise 21: {StringFunctions.EmailMasker("john.doe@example.com")}");                   // Output: j********@example.com

        // Exercise 22: Convert a sentence into a list of ASCII codes.
        Console.WriteLine($"Exercise 22: {string.Join(", ", StringFunctions.ConvertStringToASCIICodes("Hi"))}");    // Output: 72, 105

        // Exercise 23: Remove duplicate words from a sentence.
        Console.WriteLine($"Exercise 23: {StringFunctions.RemoveDuplicates("hello hello world world")}");           // Output: hello world

        // Exercise 24: Extract the file extension from a filename.
        Console.WriteLine($"Exercise 24: {StringFunctions.GetFileExtension("File.txt")}");                          // Output: txt

        // Exercise 25: Replace newlines with spaces in a string.
        Console.WriteLine($"Exercise 25: {StringFunctions.ReplaceNewlineWithWhitespace("hello\nworld")}");          // Output: hello world
    }
}