namespace DSA.Algorithms.ArraysAndHashing
{
  public class ContainsDuplicate
  {
    // https://leetcode.com/problems/contains-duplicate/description/
    // https://www.youtube.com/watch?v=3OamzN90kPg
    public static bool Run(int[] nums)
    {
      var hashSet = new HashSet<int>();
      foreach (var num in nums)
      {
        if (hashSet.Contains(num))
        {
          return true;
        }

        hashSet.Add(num);
      }

      return false;
    }
  }
}