using DSA.Algorithms.ArraysAndHashing;

namespace DSA.Tests.Algorithms.ArraysAndHashing
{
  public class TestValidAnagram
  {
    [Fact]
    public void IsAnagram() => Assert.True(ValidAnagram.Run("anagram", "nagaram"));

    [Fact]
    public void IsNotAnagram() => Assert.False(ValidAnagram.Run("rat", "car"));

    [Fact]
    public void IsAlmostAnagram() => Assert.False(ValidAnagram.Run("ract", "car"));
  }
}