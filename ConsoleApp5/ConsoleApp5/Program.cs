namespace ConsoleApp5;

class Program
{
    public static void Main(string[] args)
    {
        string str = "silent@gmail.com";
        string str2 = "lisen";
        string str4 = "Hel23lo, M2Y Fr43,I;e28nd";
        string[] str3 = ["Hello", "World"];
        Console.WriteLine(Exercise_1(str));
        Console.WriteLine(Exercise_2(str));
        Console.WriteLine(Exercise_3(str));
        Console.WriteLine(Exercise_4(str));
        Console.WriteLine(Exercise_5(str));
        Console.WriteLine(Exercise_6(str2));
        Console.WriteLine(Exercise_7(str2));
        Console.WriteLine(Exercise_8(str));
        Console.WriteLine(Exercise_9(str2));
        Console.WriteLine(Exercise_10(str));
        Console.WriteLine(Exercise_11(str3));
        Console.WriteLine(Exercise_12(str2));
        Console.WriteLine(Exercise_13(str2));
        Console.WriteLine(Exercise_15(str));
        Console.WriteLine(Exercise_16(str));
        Console.WriteLine(Exercise_17(str4));
        Console.WriteLine(Exercise_18(str,str2));
        Console.WriteLine(Exercise_19(str4));
        Console.WriteLine(Exercise_20(str4));
        Console.WriteLine(Exercise_21(str));
    }

    public static int Exercise_1(string str)
    {
        return str.Length;
    }
    public static string Exercise_2(string str)
    {
        return str.ToUpper();
    }
    public static string Exercise_3(string str)
    {
        return str.ToLower();
    }
    public static bool Exercise_4(string str)
    {
        if (str.StartsWith(Console.ReadLine()))
        {
            return true;
        }
        return false;
    }
    public static bool Exercise_5(string str)
    {
        if (str.EndsWith(Console.ReadLine()))
        {
            return true;
        }
        return false;
    }
    public static bool Exercise_6(string str2)
    {
        for (int i = 0; i < str2.Length; i++)
        {
            if (str2[i] < 48 || str2[i] > 57)
            {
                return false;
            }
        }
        return true;
    }
    public static bool Exercise_7(string str2)
    {
        str2 = str2.ToUpper();
        for (int i = 0; i < str2.Length; i++)
        {
            if (str2[i] < 65 || str2[i] > 90)
            {
                return false;
            }
        }
        return true;
    }

    public static string Exercise_8(string str)
    {
        char c = str[0];
        string str1 = null;
        for (int i = 1; i < str.Length; i++)
        {
            str1 += str[i];
        }
        return c.ToString().ToUpper() + str1;
    }
    public static string Exercise_9(string str)
    {
        char[] c = str.ToCharArray();
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] >= 65 && c[i] <= 90)
                c[i] = char.ToLower(c[i]);
            else if (c[i] >= 97 && c[i] <= 122)
                c[i] = char.ToUpper(c[i]);
        }
        str = string.Join("", c);
        return str; ;
    }
    public static string Exercise_10(string str)
    {
        string ressult = string.Empty;
        string[] s = str.Split(" ");
        foreach (string word in s)
            ressult += word;
        return ressult;
    }
    public static string Exercise_11(string[] s)
    {
        string ressult = string.Empty;
        foreach (string word in s)
            ressult += word;
        return ressult;
    }
    public static string Exercise_12(string str)
    {
        int lCount = 0, tCount = 0;
        string ressult = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
                lCount++;
            else
                break;
        }
        int l = str.Length;
        for (int i = l; i > 0; i--)
        {
            if (str[i - 1] == ' ')
                tCount++;
            else
                break;
        }
        for (int i = lCount; i < str.Length - (tCount); i++)
        {
            ressult += str[i];
        }
        return ressult;
    }
    public static int Exercise_13(string str)
    {
        return str.Split(' ').Length - 1;
    }
    public static string Exercise_15(string str)
    {
        string ressult = string.Empty;
        for (int i = 0; i < 5; i++)
        {
            ressult += str[i];
        }
        return ressult;

    } 
    public static string Exercise_16(string str)
    {
        string ressult = string.Empty;
        for (int i = str.Length; i >str.Length-3; i--)
            ressult += str[i-1];
        char[] chars = ressult.ToCharArray();
        Array.Reverse(chars);
        ressult = string.Join("", chars);
        return ressult;

    }
    public static string Exercise_17(string str)
    {
        return str.Replace(",", ";");

    }
    public static bool Exercise_18(string str,string str2)
    {
        int s1=0; 
        int s2 = 0;
        for (int i = 0; i < str.Length; i++)
        {
            s1 += str[i];
        }
        for (int i = 0; i < str2.Length; i++)
        {
            s2 += str2[i];
        }
        if (s1 == s2)
            return true;
        return false;
    }
    public static int Exercise_19(string str)
    {
        string ressult = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 48 && str[i] <= 57)
            {
                ressult += str[i];
            }
        }
        return Convert.ToInt32(ressult);
    } 
    public static string Exercise_20(string str)
    {
        string ressult = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
            {
                ressult += str[i];
            }
        }
        return ressult;
    }
    public static string Exercise_21(string str)
    {
        char[] chars = str.ToCharArray();
        int j = Array.IndexOf(chars, '@');
        for (int i = 1; i < j; i++)
              chars[i] = '*';
        string ressult = string.Join("", chars);
        return ressult;
    }

    }
