namespace DSA.Algorithms.TwoPointers
{
  public class HappyNumber
  {
    // https://leetcode.com/problems/happy-number/description/
    // https://www.youtube.com/shorts/73l43ouxp68
    public static bool Run(int n)
    {
      var slow = n;
      var fast = SumOfSquared(n);
      while (slow != fast && fast != 1)
      {
        slow = SumOfSquared(slow);
        fast = SumOfSquared(SumOfSquared(fast));
      }

      return fast == 1;
    }

    private static int SumOfSquared(int n)
    {
      var result = 0;
      while (n > 0)
      {
        var digit = n % 10;
        result += digit * digit;
        n /= 10;
      }

      return result;
    }
  }
}