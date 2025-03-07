using DSA.Algorithms.PrefixSum;

namespace DSA.Tests.Algorithms.PrefixSum
{
  public class TestRangeSumQuery2DImmutable
  {
    [Fact]
    public void Test()
    {
      var sumMatrix = new RangeSumQuery2DImmutable([[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]]);

      Assert.Equal(8, sumMatrix.SumRegion(2, 1, 4, 3));
      Assert.Equal(11, sumMatrix.SumRegion(1, 1, 2, 2));
      Assert.Equal(12, sumMatrix.SumRegion(1, 2, 2, 4));
    }
  }
}