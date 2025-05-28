using System;

public class Kata
{
    public static int GetAge(string inputString)
    {
        return int.Parse(inputString.Substring(0, inputString.IndexOf(' ')));
    }
}