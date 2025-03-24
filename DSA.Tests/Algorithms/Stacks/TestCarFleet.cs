using DSA.Algorithms.Stacks;

namespace DSA.Tests.Algorithms.Stacks
{
  public class TestCarFleet
  {
    [Fact]
    public void ThreeFleet() => Assert.Equal(3, CarFleet.Run(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]));

    [Fact]
    public void SingleCarSingleFleet() => Assert.Equal(1, CarFleet.Run(10, [3], [3]));

    [Fact]
    public void MultipleCarsSingleFleet() => Assert.Equal(1, CarFleet.Run(100, [0, 2, 4], [4, 2, 1]));

    [Fact]
    public void ArrivingAtTheSameTime() => Assert.Equal(1, CarFleet.Run(6, [2, 5], [4, 1]));
  }
}