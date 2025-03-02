namespace DSA.Algorithms.Arrays
{
  public class MinSubArrayLen
  {
    // https://leetcode.com/problems/minimum-size-subarray-sum
    public static int Run(int target, int[] nums)
    {
      var length = nums.Length;

      var currSum = 0;
      var currLen = 0;
      var result = 0;

      for (int i = 0; i < length; i++)
      {
        currLen++;

        currSum += nums[i];
        if (currSum >= target)
        {
          if (result == 0 || result > currLen)
          {
            result = currLen;
          }

          currLen = 0;
          currSum = 0;
        }
      }

      return result;
    }
  }
}