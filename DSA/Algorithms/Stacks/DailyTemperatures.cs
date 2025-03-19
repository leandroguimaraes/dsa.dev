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
        // [73, 74, 75, 71, 69, 72, 76, 73]
        // [ 1,  1,  4,  2,  1,  1,  0,  0]
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