public class Dinglemouse
{

    public static int[] humanYearsCatYearsDogYears(int humanYears)
    {
        int catYears = 15;
        int dogYears = 15;

        if (humanYears > 1)
        {
            catYears += 9; 
            dogYears += 9; 
            if (humanYears > 2)
            {
                catYears += (humanYears - 2) * 4; 
                dogYears += (humanYears - 2) * 5; 
            }
        }

        return new int[] { humanYears, catYears, dogYears };
    }

}