using DSA.Algorithms.Stacks;

namespace DSA.Tests.Algorithms.Stacks
{
  public class TestStockSpanProblem
  {
    [Fact]
    public void TestCase() => Assert.Equal([1, 1, 1, 2, 1, 4, 6], StockSpanProblem.Run([100, 80, 60, 70, 60, 75, 85]));

    [Fact]
    public void TestCase2() => Assert.Equal([1, 1, 2, 4, 5, 1], StockSpanProblem.Run([10, 4, 5, 90, 120, 80]));
  }
}