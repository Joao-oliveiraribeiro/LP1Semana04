using System;

class BetterDecorador
{
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


    }
}