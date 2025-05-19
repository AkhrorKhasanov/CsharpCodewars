using System;
using System.Linq;
public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    int[] res = new int[n];
    for (int i = n; i > 0; i--) {
      res[n - i] = i;
    }
    return res;
  }
}