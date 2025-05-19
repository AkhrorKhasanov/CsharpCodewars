public class Kata 
{
    public static int FindSmallestInt(int[] arr) 
    {
      int min = arr[0];
      for (int i = 0; i < arr.Length; i++) {
        if (min > arr[i]) {
          min = arr[i];
        }
      }
      return min;
    }
}