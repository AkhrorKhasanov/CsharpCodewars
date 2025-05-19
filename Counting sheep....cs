using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int c = 0;
    for (int i = 0; i < sheeps.Length; i++) {
      if (sheeps[i]) {
        c++;
      }
    }
    return c;
  }
}