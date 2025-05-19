class Kata
{
    public static int StrCount(string str, char letter)
    {
        if (str.Length == 0) {
          return 0;
        }
      int c = 0;
      for (int i = 0; i < str.Length; i++) {
        if (str[i] == letter) {
          c++;
        }
      }
      return c;
    }
}