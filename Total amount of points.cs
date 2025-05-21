using System.Linq;
using System;
public static class Kata
{
    public static int TotalPoints(string[] games)
    {
        int c = 0;
        for (int i = 0; i < 10; i++)
        {
            int x = Convert.ToInt32(games[i][0]);
            int y = Convert.ToInt32(games[i][2]);
            if (x > y)
            {
                c += 3;
            }
            else if (x == y)
            {
                c++;
            }
        }
        return c;
    }
}