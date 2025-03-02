namespace DSA.Algorithms.PrefixSum
{
  public class MultiplyAllExceptCurr
  {
    // https://leetcode.com/problems/product-of-array-except-self/description/
    public static int[] Run(int[] arr)
    {
      var length = arr.Length;

      var curr = 1;
      var result = new int[length];

      for (int i = 0; i < length; i++)
      {
        result[i] = curr;
        curr *= arr[i];
      }

      curr = 1;

      for (int i = length - 1; i >= 0; i--)
      {
        result[i] *= curr;
        curr *= arr[i];
      }

      return result;
    }
  }
}