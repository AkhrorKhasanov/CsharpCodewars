public class Sleigh
{
  public static bool Authenticate(string name, string password)
  {
    return name == "Santa Claus" && password == "Ho Ho Ho!";
  }
}