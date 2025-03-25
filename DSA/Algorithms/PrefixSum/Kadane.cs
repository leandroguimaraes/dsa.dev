namespace DSA.Algorithms.PrefixSum
{
  public class Kadane
  {
    // https://en.wikipedia.org/wiki/Maximum_subarray_problem
    // https://www.youtube.com/watch?v=5WZl3MMT0Eg
    public static int Run(int[] arr)
    {
      var length = arr.Length;

      var maxOnIndex = arr[0];
      var result = arr[0];

      for (int i = 1; i < length; i++)
      {
        maxOnIndex = Math.Max(arr[i], maxOnIndex + arr[i]);
        result = Math.Max(result, maxOnIndex);
      }

      return result;
    }
  }
}