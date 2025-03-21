namespace DSA.Algorithms.Stacks
{
  public class StockSpanProblem
  {
    // https://www.geeksforgeeks.org/the-stock-span-problem/
    public static int[] Run(int[] input)
    {
      var length = input.Length;
      var result = new int[length];
      var stack = new Stack<int>();
      for (int i = 0; i < length; i++)
      {
        while (stack.Count > 0 && input[stack.Peek()] <= input[i])
        {
          stack.Pop();
        }

        if (stack.Count == 0)
        {
          result[i] = i + 1;
        }
        else
        {
          result[i] = i - stack.Peek();
        }

        stack.Push(i);
      }

      return result;
    }
  }
}