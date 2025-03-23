namespace DSA.Algorithms.Backtracking
{
  public class GenerateParentheses
  {
    // https://leetcode.com/problems/generate-parentheses/description/
    public static string[] Run(int n)
    {
      var result = Backtracking(n);
      return result;
    }

    private static string[] Backtracking(int n)
    {
      var result = new List<string>();
      BacktrackingAux(n, 0, 0, "", result);

      return [.. result];
    }

    private static void BacktrackingAux(int n, int nOpen, int nClose, string curr, IList<string> result)
    {
      if (nOpen <= n)
      {
        BacktrackingAux(n, nOpen + 1, nClose, curr + '(', result);
      }

      if (nClose < nOpen)
      {
        BacktrackingAux(n, nOpen, nClose + 1, curr + ')', result);
      }

      if (nOpen == nClose && nOpen == n)
      {
        result.Add(curr);
      }
    }
  }
}