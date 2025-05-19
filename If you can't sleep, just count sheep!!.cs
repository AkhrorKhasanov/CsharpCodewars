using System;

public static class Kata
{
  public static string CountSheep(int n)
  {
    string s = "";
    for (int i = 0; i < n; i++) {
      s += (i + 1) + " sheep...";
    }
    return s;
  }
}