public class Kata
{
    public static string UpdateLight(string current)
    {
        if (current == "red") {
          return "green";
        } else if (current == "yellow") {
          return "red";
        }
      return "yellow";
    }
}