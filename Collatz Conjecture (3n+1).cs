public class Kata
{
  public static uint Hotpo(uint n)
  {
    uint c = 0;
    while (n != 1) {
      if (n % 2 == 0) {
        n /= 2;
      } else {
        n = 3 * n + 1;
      }
      c++;
    }
    return c;
  }
}