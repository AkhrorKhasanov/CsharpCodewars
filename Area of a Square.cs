using System;
public class Kata
{
  public static double SquareArea(double A)
  {
    double pi = Math.PI;
    double res = Math.Pow(2 * A / pi, 2);
    return Math.Round(res, 2);
  }
}