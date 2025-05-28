using System;
public class Kata
{
    public static string AbbrevName(string name)
    {
        int ind = name.IndexOf(' ');
        return (name[0] + "." + name[ind + 1]).ToUpper();
    }
}