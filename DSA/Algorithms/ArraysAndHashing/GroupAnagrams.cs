namespace DSA.Algorithms.ArraysAndHashing
{
  public class GroupAnagrams
  {
    // https://leetcode.com/problems/group-anagrams/
    // https://www.youtube.com/watch?v=vzdNOK2oB2E
    public static IList<IList<string>> Run(string[] strs)
    {
      var indexes = new List<string>();
      var result = new List<IList<string>>();
      foreach (var str in strs)
      {
        var length = indexes.Count;
        var indexExist = false;
        for (int i = 0; i < length; i++)
        {
          if (ValidAnagram.Run(indexes[i], str))
          {
            result[i].Add(str);
            indexExist = true;
            break;
          }
        }

        if (!indexExist)
        {
          indexes.Add(str);
          result.Add([str]);
        }
      }

      return result;
    }
  }
}