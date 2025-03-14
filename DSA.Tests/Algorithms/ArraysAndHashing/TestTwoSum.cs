using DSA.Algorithms.ArraysAndHashing;

namespace DSA.Tests.Algorithms.ArraysAndHashing
{
  public class TestTwoSum
  {
    [Fact]
    public void Check() => Assert.Equal([0, 1], TwoSum.Run([2, 7, 11, 15], 9));

    [Fact]
    public void Check2() => Assert.Equal([1, 2], TwoSum.Run([3, 2, 4], 6));

    [Fact]
    public void Only2elements() => Assert.Equal([0, 1], TwoSum.Run([3, 3], 6));
  }
}