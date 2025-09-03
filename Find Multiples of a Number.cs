using System.Collections.Generic;

public class Kata
{
    public static List<int> FindMultiples(int n, int limit)
    {
        List<int> lst = new List<int>();
        for (int i = 1; i < limit + 1; i++)
        {
            if (n * i > limit)
            {
                break;
            }
            lst.Add(n * i);
        }
        return lst;
    }
}