namespace StringManipulation
{
    class StringFunctions
    {
        public static int CountCharactersInString(string input)
        {
            try
            {
                // Checking only for letters and not characters.
                return input.Count(char.IsLetter);
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }

        public static string ConvertToUpperCase(string input)
        {
            try
            {
                return input.ToUpper();
            }
            catch (ArgumentNullException e)
            {
                return $"Exception: {e}";
            }
        }

        public static string ConvertToLowerCase(string input)
        {
            try
            {
                return input.ToLower();
            }
            catch (ArgumentNullException e)
            {
                return $"Exception: {e}";
            }
        }

        public static bool CheckStartPrefix(string input, string prefix)
        {
            try
            {
                // Making them both lower first and using StartsWith().
                return input.ToLower().StartsWith(prefix.ToLower());
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool CheckEndPrefix(string input, string prefix)
        {
            try
            {
                return input.ToLower().EndsWith(prefix.ToLower());
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool CheckDigit(string input)
        {
            try
            {
                // Trying to parsing the entire string into an int and discarding the output with _.
                return int.TryParse(input, out _);
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static bool CheckLetter(string input)
        {
            try
            {
                // Using the All() LINQ to see if there are letters.
                return input.All(char.IsLetter);
            }
            catch (ArgumentNullException)
            {
                return false;
            }
        }

        public static string Capitalize(string input)
        {
            try
            {
                // Adding strings with an upper first char and a lower substring starting from index 1.
                return char.ToUpper(input[0]) + input.Substring(1).ToLower();
            }
            catch (ArgumentNullException e)
            {
                return $"Exception: {e}";
            }
        }

        public static string SwapLettersCases(string input)
        {
            try
            {
                // Making a list of chars for the result.
                char[] result = new char[input.Length];

                // Generating a for loop for changing each character.
                for (int i = 0; i < input.Length; i++)
                {
                    char c = input[i];
                    // Using a ternary conditional operator.
                    result[i] = char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
                }

                return new string(result);
            }
            catch (ArgumentNullException e)
            {
                return $"Exception: {e}";
            }
        }

        public static string[] SplitString(string input)
        {
            try
            {
                // Using Split() to return a list.
                return input.Split(' ');
            }
            catch (ArgumentNullException e)
            {
                // Changing the exception type to string[].
                return new string[] { $"Exception: {e}" };
            }
        }

        public static string ConcatWords(string[] input)
        {
            try
            {
                string result = "";
                // Using lambda function to loop.
                input.ToList().ForEach(c => result += c + " ");
                return result;
            }
            catch (ArgumentNullException e)
            {
                return $"Exception: {e}";
            }
        }

        public static string TrimWhitespaces(string input)
        {
            try
            {
                return input.Trim();
            }
            catch (ArgumentNullException e)
            {
                return $"Exception: {e}";
            }
        }

        public static int CountSpaces(string input)
        {
            try
            {
                // Using lambda functions to get the number of whitespaces and count them.
                return input.Count(c => c == ' ');
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool IsEmail(string input)
        {
            try
            {
                // Using Contains() to check if it has @ and .
                return input.Contains("@") && input.Contains(".");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string FirstFiveCharacters(string input)
        {
            try
            {
                return input.Substring(0, 5);
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }

        public static string LastThreeCharacters(string input)
        {
            try
            {
                return input.Substring(input.Length - 3, 3);
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }

        public static string ChangeCommaToSemicolon(string input)
        {
            try
            {
                return input.Replace(",", ";");
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }

        public static bool AreAnagrams(string input, string input1)
        {
            try
            {
                // Take the input, make a loop in a lambda. Sort the loop. Change to array and change the array into a string to equalize.
                return new string(input.OrderBy(c => c).ToArray()) == new string(input1.OrderBy(c => c).ToArray());
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string[] GetDigitsFromString(string input)
        {
            try
            {
                // Checking is every char is a digit using Where(), converting them back to a string using Select() and finally
                // turning them back to an array to match output type.
                return input.Where(char.IsDigit).Select(c => c.ToString()).ToArray();
            }
            catch (Exception e)
            {
                return new string[] { $"Exception: {e}" };
            }
        }

        public static char[] GetLettersInString(string input)
        {
            try
            {
                // Using Where() to find a letter and then converting the chars into an array.
                return input.Where(char.IsLetter).ToArray();
            }
            catch (Exception e)
            {
                return $"Exception: {e}".ToCharArray();
            }
        }

        public static string EmailMasker(string input)
        {
            try
            {
                int atIndex = input.IndexOf('@');
                // Add the first character, make a repeated string and add the remaining after the @.
                return input[0] + new string('*', atIndex) + input.Substring(atIndex, input.Length - atIndex);
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }

        public static byte[] ConvertStringToASCIICodes(string input)
        {
            try
            {
                return Encoding.ASCII.GetBytes(input);
            }
            catch (Exception)
            {
                return new byte[] { 0 };
            }
        }

        public static string RemoveDuplicates(string input)
        {
            try
            {
                // Splitting the string into words, finding only the distinct words and joining them into a string.
                return string.Join(" ", input.Split(" ").Distinct());
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }

        public static string GetFileExtension(string input)
        {
            try
            {
                int dotIndex = input.IndexOf(".") + 1;  // add 1 to remove the ".".

                return input.Substring(dotIndex, input.Length - dotIndex);
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }

        public static string ReplaceNewlineWithWhitespace(string input)
        {
            try
            {
                return input.Replace("\n", " ");
            }
            catch (Exception e)
            {
                return $"Exception: {e}";
            }
        }
    }
}