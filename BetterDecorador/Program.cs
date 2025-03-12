using System;

class BetterDecorador
{
    private static string Decor(string s, char dec, int count)
    {
        string decoration = new string(dec, count);
        return $"{decoration} {s} {decoration}";
    }

 