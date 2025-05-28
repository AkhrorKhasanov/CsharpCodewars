using System.Collections.Generic;

public class Kata
{
    public static List<int> ReverseList(List<int> list)
    {
        List<int> reversedList = new List<int>();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            reversedList.Add(list[i]);
        }
        return reversedList;
    }
}