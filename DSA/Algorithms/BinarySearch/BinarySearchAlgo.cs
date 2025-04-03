namespace DSA.Algorithms.BinarySearch
{
  public class BinarySearchAlgo
  {
    // https://leetcode.com/problems/binary-search/description/
    public static int Run(int[] nums, int target)
    {
      var length = nums.Length;
      var l = 0;
      var r = length - 1;
      var p = r - l / 2;
      while (l < r)
      {
        if (nums[p] == target)
        {
          return target;
        }

        if (target > nums[p])
        {
          l = p + 1;
        }
        else
        {
          r = p - 1;
        }

        p = r - l / 2;
      }

      return -1;
    }
  }
}