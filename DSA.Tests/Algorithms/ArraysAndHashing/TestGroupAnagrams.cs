using DSA.Algorithms.ArraysAndHashing;

namespace DSA.Tests.Algorithms.ArraysAndHashing
{
  public class TestGroupAnagrams
  {
    [Fact]
    public void BasicTest() => Assert.Equal([["eat", "tea", "ate"], ["tan", "nat"], ["bat"]], GroupAnagrams.Run(["eat", "tea", "tan", "ate", "nat", "bat"]));

    [Fact]
    public void SingleEmptyString() => Assert.Equal([[""]], GroupAnagrams.Run([""]));

    [Fact]
    public void SingleStrWithOneChar() => Assert.Equal([["a"]], GroupAnagrams.Run(["a"]));
  }
}