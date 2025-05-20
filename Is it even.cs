public class Number
{
    public bool IsEven(double n)
    {
        if (n % 1 != 0 || n % 2 == 1)
        {
            return false;
        }
        return true;
    }
}