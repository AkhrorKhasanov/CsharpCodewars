namespace Solution
{
    public static class Program
    {
        public static double basicOp(char op, double v1, double v2)
        {
            if (op == '+')
            {
                return v1 + v2;
            }
            else if (op == '-')
            {
                return v1 - v2;
            }
            else if (op == '*')
            {
                return v1 * v2;
            }
            return v1 / v2;
        }
    }
}