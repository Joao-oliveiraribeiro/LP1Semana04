using System;

/// <summary>
/// Code to input a string a character and a number and put the inputed character 
/// in both sides of the string the number of times specified by the user
/// </summary>
class Program
{   
    /// <summary>
    /// Get numbers convert into a string 
    // and return a interpolated string
    /// </summary>
    /// <param name="s"> inputed string </param>
    /// <param name="dec"> inputed character </param>
    /// <param name="count"> inputed number of times of character </param>
    /// <returns> Interpolated string with specified functions </returns> <summary>
    private static string Decor(string s, char dec, int count)
    {
        string decoration = new string(dec, count);
        return $"{decoration} {s} {decoration}";
    }

    /// <summary>
    /// If user doesnt specify args calls this method and returns a predifined string
    /// </summary>
    /// <returns> A predifined string  </returns>
    private static string Decor()
    {
        return Decor("User did not specify args!", '=', 3);
    }

    /// <summary>
    /// Get input arguments in console call Decor method and write in console
    /// </summary>
    /// <param name="args"> string, character, int </param>
    static void Main(string[] args)
    {
        if (args.Length ==0)
        {
            string result = Decor();
            Console.WriteLine(result);   
        }

        else
        {
            string inputString = args[0];
            char decoratorChar = char.Parse(args[1]);
            int count = int.Parse(args[2]);
            string result = Decor(inputString, decoratorChar, count);
            Console.WriteLine(result);  
        }
    }
}