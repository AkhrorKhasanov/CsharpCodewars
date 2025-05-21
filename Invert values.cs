using System.Linq;
namespace Solution
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            int n = input.Length;
            int[] output = new int[n];
            for (int i = 0; i < n; i++)
            {
                output[i] = -input[i];
            }
            return output;
        }
    }
}