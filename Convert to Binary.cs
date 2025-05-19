using System;

public static class Kata
{
  public static int ToBinary(int n)
  {
    string s = Convert.ToString(n, 2);
    return int.Parse(s);
  }
}