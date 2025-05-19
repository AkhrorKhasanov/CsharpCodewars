using System.Linq;
public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
      int one = a + b + c;
      int two = a * b * c;
      int three = (a + b) * c;
      int four = a * (b + c);
      int five = a + b * c;
      int six = a * b + c;
      int[] nums = {one, two, three, four, five, six};
      return nums.Max();
    }
}