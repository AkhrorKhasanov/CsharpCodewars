using System;
using System.Collections.Generic;

public static class Kata
{
  public static List<int> MultipleOfIndex(List<int> xs)
  {
    List<int> arr = new List<int>();
    if (xs[0] == 0) {
      arr.Add(0);
    }
    for (int i = 1; i < xs.Count; i++) {
      if (xs[i] % i == 0) {
        arr.Add(xs[i]);
      }
    }
    return arr;
  }
}