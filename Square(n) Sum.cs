using System;
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    double c = 0;
    for (int i = 0; i < numbers.Length; i++) {
      c += Math.Pow(numbers[i], 2);
    }
    return (int)c;
  }
}