namespace DSA.Algorithms.ArraysAndHashing
{
  public class ValidAnagram
  {
    // https://leetcode.com/problems/valid-anagram/description/
    // https://www.youtube.com/watch?v=9UtInBqnCgA
    public static bool Run(string s, string t)
    {
      var sHashMap = StrToDictionary(s);
      var tHashMap = StrToDictionary(t);
      if (sHashMap.Count != tHashMap.Count)
      {
        return false;
      }

      foreach (var item in sHashMap)
      {
        if (tHashMap.GetValueOrDefault(item.Key, 0) != item.Value)
        {
          return false;
        }
      }

      return true;
    }

    private static Dictionary<char, int> StrToDictionary(string s)
    {
      var result = new Dictionary<char, int>();
      foreach (var letter in s)
      {
        result[letter] = result.GetValueOrDefault(letter, 0) + 1;
      }

      return result;
    }
  }
}