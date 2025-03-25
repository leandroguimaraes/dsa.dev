using System.Dynamic;

namespace DSA.Algorithms.Stacks
{
  public class EvaluateReversePolishNotation
  {
    // https://leetcode.com/problems/evaluate-reverse-polish-notation/description/
    // https://www.youtube.com/watch?v=iu0082c4HDE
    public static int Run(string[] tokens)
    {
      var operators = new Dictionary<string, Func<int, int, int>>()
      {
        { "+", (a, b) => a + b },
        { "-", (a, b) => a - b },
        { "*", (a, b) => a * b },
        { "/", (a, b) => a / b }
      };

      var result = 0;

      var stack = new Stack<string>();
      foreach (var token in tokens)
      {
        if (operators.TryGetValue(token, out Func<int, int, int>? method))
        {
          var value1 = int.Parse(stack.Pop());
          var value2 = int.Parse(stack.Pop());

          result = method(value2, value1);

          stack.Push(result.ToString());
        }
        else
        {
          stack.Push(token);
        }
      }

      return result;
    }
  }
}