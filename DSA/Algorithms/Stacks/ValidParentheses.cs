namespace DSA.Algorithms.Stacks
{
  public class ValidParentheses
  {
    // https://leetcode.com/problems/valid-parentheses/description/
    public static bool Run(string input)
    {
      var validChars = new Dictionary<char, char>()
      {
        [')'] = '(',
        ['}'] = '{',
        [']'] = '[',
      };

      var stack = new Stack<char>();
      foreach (var letter in input)
      {
        var isOpen = !validChars.ContainsKey(letter);
        if (isOpen)
        {
          stack.Push(letter);
        }
        else if (stack.Count > 0 && stack.Peek() == validChars[letter])
        {
          stack.Pop();
        }
        else
        {
          return false;
        }
      }

      return true;
    }
  }
}