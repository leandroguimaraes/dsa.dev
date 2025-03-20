namespace DSA.Algorithms.Stacks
{
  public class DailyTemperatures
  {
    // https://leetcode.com/problems/daily-temperatures/description/
    public static int[] Run(int[] temperatures)
    {
      var length = temperatures.Length;
      var stack = new Stack<int>();
      var result = new int[length];
      for (int i = 0; i < length; i++)
      {
        while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
        {
          var currIndex = stack.Pop();
          result[currIndex] = i - currIndex;
        }

        stack.Push(i);
      }

      return result;
    }
  }
}