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
    }
}