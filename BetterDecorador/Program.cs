using System;

class BetterDecorador
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

    static void Main(string[] args)
    {
        string inputString = args[0];
        char decoratorChar = args[1][0];
        int count = int.Parse(args[2]);

        string result = Decor(inputString, decoratorChar, count);
        Console.WriteLine(result);
    }
}