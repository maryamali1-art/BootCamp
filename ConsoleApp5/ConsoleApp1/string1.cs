using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class string1
    {
        public static string str = "hello";

        //1 Count the number of charcters in a string
        static int CountCharacters()
        {
            return str.Length;
        }
        //2 Conver a string to uppercase
        static string ConverToUppercase()
        {
            return str.ToUpper();

        }
        //3-Convert a string to lowercase by .ToLower()

        static string ConvertoLowercase()
        {
            return str.ToLower();

        }
        //4- Check if a string starts with a given prefix.
        static bool CheckIfStart()
        {
            return (str.StartsWith("wel"));
        }
        //5-Check if a string ends with a given suffix.
        static bool CheckIfEndWith()
        {
            return (str.EndsWith(".txt"));

        }
        //6

        //7


        //8-Capitalize the first character of a string.
        public static string CapitalizeFirstCharacter()
        {
            return str[0].ToString().ToUpper() + str.Substring(1, str.Length - 1);
        }
        //9-Swap the case of each character in a string.

        public static void SwapCase()
        {
            string str1;
            string str0 = "heLLO";
            for (int i = 0; i < str.Length; i++)
            {
                if (str0[i].ToString() == str0[i].ToString().ToLower())
                {
                    str1 = str0[i].ToString().ToUpper();
                }
            }
        }
        //10-Split a string into words.
        public static string ListOfWords()
        {
            string a = "{";
            string str0 = "hello world";
            string[] str1 = str0.Split(' ');
            for (int i = 0; i < str1.Length; i++)
            {
                a += str1[i].ToString() + ",";
            }
            return a + "}";
        }
        //11-Join a list of words into a string.
        public static string ListOfWordsIntoString()
        {
            string str0 = @"['hello','word']";
            str0 = str0.Trim('[', ']').Replace(",", " ");
            return str0;
        }
        //12-Remove leading and trailing whitespace from a string.

        public static string RemoveLeadingandTrailing()
        {

            return str.Trim();

        }
        //13- Count the number of spaces in a string.
        public static int CountNumberOfSpaces()
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        //14- Check if a string is an email address format.

        public static bool IsEmail()
        {
            string email = "example@example.com";
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        //15-Get the first 5 characters of a string.

        public static string First5Characters()
        {
            return str.Substring(0, 5);
        }
        //16-Get the last 3 characters of a string.

        public static string Last3Characters()
        {
            return str.Substring(str.Length - 3, 3);
        }
        //17-Replace commas with semicolons in a string.

        public static string ReplaceCommasWithSemicolons()
        {
            string str1 = "'a,b,c'";
            return str1.Replace(",", ";");
        }
        //18
        /* public static bool IsAnagrams()
         {
             for (int i=0; i < str.Length; i++)
             {
                 for( int j=0; j < str.Length; i++)
                 {

                 }
             }
         }*/
        //19- Find all the digits in a string.
        public static List<int> ExtractDigitsAsIntegers()
        {
            string str0 = "bft654";
            return str0.Where(char.IsDigit)
                        .Select(c => int.Parse(c.ToString()))
                        .ToList();
        }
        //20
        //21-Mask an email address (e.g., a***@domain.com).

        public static string MaskEmail()
        {
            string email = "example@example.com";
            int index = email.IndexOf("@");
            string str1 = email.Substring(index);
            return email[0] + "***" + str1;
        }
        //23-Remove duplicate words from a sentence.
        public static string RemoveDuplicateWords()
        {
            string str1 = "hello hello world";
            string[] words = str1.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                if (!result.Contains(word))
                {
                    result += word + " ";
                }
            }

            return result.Trim();


        }
        //24- Extract the file extension from a filename.
        public static string ExtractFileExtension()
        {
            string FilName = "example.txt";
            int index = FilName.IndexOf(".");
            string str1 = FilName.Substring(index);
            return str1;
        }
        //25- Replace newlines with spaces in a string.
        public static string ReplaceNewlinesWithSpaces()
        {
            string str0 = " 'hello\nworld' ";
            for (int i = 0; i < str0.Length; i++)
            {
                str0 = str0.Replace("\n", " ");
            }
            return str0;
        }
        //26- Convert a string date from 'YYYY-MM-DD' to 'DD/MM/YYYY'.
        public static string ConvertStringDate()
        {
            string date = "2024-01-01";
            string[] str0 = date.Split('-');
            return $"{str0[2]}/{str0[1]}/{str0[0]}";
        }
        //27-Find how many times a specific character appears in a string.
        public static int timesOfRepeCharacter()
        {
            char ch = 'l';
            char[] chars = str.ToCharArray();
            int count = 0;
            foreach (char c in chars)
            {
                if (c == ch)
                {
                    count++;

                }
            }
            return count;

        }
        //28-Check if a string contains any special characters.
        public static bool IfStringContainsSpecialCharacters()
        {
            string str0 = "asfdgfhgh#";
            foreach (char c in str0)
            {
                if (char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;


        }
        //29- Convert snake_case to camelCase.
        public static string ConvertSnake_caseToCamelCase()
        {
            string str0 = "my_name";
            string[] str1 = str0.Split('_');
            string str2 = str1[0];
            return str1[0] + char.ToUpper(str1[1][0]) + str1[1].Substring(1);

        }
        //30-Convert camelCase to snake_case.
        /*  public static string ConvertCamelCaseToSnake_case()
          {
              string str0 = "myName";
              string[] str1 = str0.Split('_');
              string str2 = str1[0].ToString();
        }*/
        //31- Replace all numeric values in a string with #.
        public static string ReplaceNumericValues()
        {
            string str0 = "sdrft545356";
            string result = "";
            foreach (char c in str0)
            {
                result += char.IsDigit(c) ? '#' : c;
            }
            return result;
        }
        //32- Count how many words are capitalized.
        public static int NumberOfWordsCapitalized()
        {
            string str0 = "HeLLo World";
            string[] str1 = str0.Split(' ');
            int count = 0;
            foreach (string c in str1)
            {
                foreach (char ch in c)
                {
                    if (char.IsUpper(ch))
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
        //33-Remove all vowels from a string.

        public static string RemoveVowels()
        {
            string vowels = "aeiouAEIOU";
            string result = "";

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }

            return result;
        }
        //34-Check if a string contains only whitespace.
        public static bool IsOnlyWhitespace()
        {
            string str1 = "   d";

            foreach (char c in str1)
            {
                if (!char.IsWhiteSpace(c))
                    return false;
            }

            return true;
        }
        //35-Replace emojis with [EMOJI] tag.
        public static string ReplaceEmoji()
        {
            string str0 = "😊 Hello 👋🌟";

            string result = "";

            foreach (char c in str0)
            {
                if (char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherSymbol)
                {
                    result += "[EMOJI]";
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
        //36-Convert binary string to decimal.
        public static int ConvertBinaryDecimal()
        {
            string binary = "1010";
            int result;
            return result = Convert.ToInt32(binary, 2);
        }
        //37-Convert decimal string to binary.
        public static string ConvertDecimalToBinary()
        {
            string decimal_ = "10";
            int number = int.Parse(decimal_);
            string result = Convert.ToString(number, 2);
            return result;
        }
        //38- Create a string pattern
        public static string pattern()
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i] + "-";
            }
            return result;
        }
        //39-Add a space after every comma.
        public static string AddSpaceAfterEveryComma()
        {

            string input = "a,b,c";
            return input.Replace(",", ", ");

        }
        //40- Trim a string to a maximum of 10 characters.
        public static string TenCharacters()
        {
            string Input = "abcdefghijk";
            return Input.Substring(0, 10);

        }
        //41- Extract phone number from a sentence.
        public static string PhoneNumber()
        {
            string result="" ;
            string Input = "Call me at 0791234567";
          foreach( var c in Input.Split(' '))
            {
                if (c.StartsWith( "07") & c.Length == 10)
                {
                    result = c;
                }
            }
            return result;

        }
        //42-Format phone number to international style.
        public static string PhoneNumberInInternationalStyle()
        {
            string result = "";
            string Input = "+9647912345678";
           
            foreach( char c in Input)
            {
                if(c == '+')
                {
                    result = "00";
                }
            }
            return result + Input.Substring(1, 13);
        }
        //45-Detect language of a sentence.       
        public static string DetectLanguage()
            {
            string input = "كيف حالك";
            string result = "";
            foreach(char c in input)
            {
                if ( c >= 0x0600 && c <= 0x06FF) 
                    result= "Arabic";
                else if ( c >= 'A' && c <= 'Z' ||  c >= 'a' && c <= 'z')
                    result= "English";
                else
                    result= "Unknown";

            }
            return result;
        }
       


    }
}