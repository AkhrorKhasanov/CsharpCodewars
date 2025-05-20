public class MathCheck
{
    public static int AreaOrPerimeter(int l, int w)
    {
        if (l != w)
        {
            return 2 * (l + w);
        }
        return l * l;
    }
}