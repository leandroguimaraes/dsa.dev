using DSA.Algorithms.Stacks;

namespace DSA.Tests.Algorithms.Stacks
{
  public class TestDailyTemperatures
  {
    [Fact]
    public void MixedValues() => Assert.Equal([1, 1, 4, 2, 1, 1, 0, 0], DailyTemperatures.Run([73, 74, 75, 71, 69, 72, 76, 73]));

    [Fact]
    public void RisingValues() => Assert.Equal([1, 1, 1, 0], DailyTemperatures.Run([30, 40, 50, 60]));

    [Fact]
    public void DecreasingValues() => Assert.Equal([0, 0, 0, 0], DailyTemperatures.Run([60, 50, 40, 30]));
  }
}