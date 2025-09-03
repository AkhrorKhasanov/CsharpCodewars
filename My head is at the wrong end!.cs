public class Kata
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        string[] res = new string[3];
        res[0] = arr[2];
        res[1] = arr[1];
        res[2] = arr[0];
        return res;
    }
}