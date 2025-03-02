using DSA.Algorithms.PrefixSum;

namespace DSA.Tests.Algorithms.PrefixSum
{
  public class TestMultiplyAllExceptCurr
  {
    [Fact]
    public void PositiveNumbers() => Assert.Equal([24, 12, 8, 6], MultiplyAllExceptCurr.Run([1, 2, 3, 4]));

    [Fact]
    public void NegativeNumbers() => Assert.Equal([-24, -12, -8, -6], MultiplyAllExceptCurr.Run([-1, -2, -3, -4]));

    [Fact]
    public void PositiveNegativeNumbers() => Assert.Equal([-30, 15, 10, -6], MultiplyAllExceptCurr.Run([-1, 2, 3, -5]));

    [Fact]
    public void OneZero() => Assert.Equal([0, 12, 0, 0], MultiplyAllExceptCurr.Run([1, 0, 3, 4]));

    [Fact]
    public void MultipleZeros() => Assert.Equal([0, 0, 0, 0], MultiplyAllExceptCurr.Run([1, 0, 0, 4]));
  }
}