namespace DSA.Algorithms.ArraysAndHashing
{
  public class TwoSum
  {
    // https://leetcode.com/problems/two-sum/description/
    // https://www.youtube.com/watch?v=KLlXCFG5TnA
    public static int[] Run(int[] nums, int target)
    {
      var length = nums.Length;
      var hashMap = new Dictionary<int, int>();
      for (int i = 0; i < length; i++)
      {
        var complement = target - nums[i];
        if (hashMap.ContainsKey(complement))
        {
          return [hashMap[complement], i];
        }

        hashMap.Add(nums[i], i);
      }

      throw new ArgumentException("Invalid arguments. There is no solution.");
    }
  }
}