public class Kata
{
    public static int[] Between(int a, int b)
    {
        int[] arr = new int[b - a + 1];
        for (int i = 0; i <= b - a; i++)
        {
            arr[i] = i + a;
        }
        return arr;
    }
}