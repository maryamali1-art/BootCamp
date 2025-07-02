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
                return input.Split(' ');
            }
            catch (ArgumentNullException e)
            {
                // Changing the exception type to string[].
                return new string[] { $"Exception: {e}" };
            }
        }
    }
}