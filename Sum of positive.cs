using System;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    if (arr.Length == 0) {
      return 0;
    }
    int c = 0;
    for (int i = 0; i < arr.Length; i++) {
      if (arr[i] > 0) {
        c += arr[i];
      }
    }
    return c;
  }
}
