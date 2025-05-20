public class Kata
{
    public int Min(int[] list)
    {
        int min = list[0];
        for (int i = 0; i < list.Length; i++)
        {
            if (min > list[i])
            {
                min = list[i];
            }
        }
        return min;
    }

    public int Max(int[] list)
    {
        int max = list[0];
        for (int i = 0; i < list.Length; i++)
        {
            if (max < list[i])
            {
                max = list[i];
            }
        }
        return max;
    }
}