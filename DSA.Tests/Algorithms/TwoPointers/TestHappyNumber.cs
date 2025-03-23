using DSA.Algorithms.TwoPointers;

namespace DSA.Tests.Algorithms.TwoPointers
{
  public class TestHappyNumber
  {
    [Fact]
    public void IsTrue() => Assert.True(HappyNumber.Run(19));

    [Fact]
    public void IsFalse() => Assert.False(HappyNumber.Run(2));

    [Fact]
    public void NumberOne() => Assert.True(HappyNumber.Run(1));

    [Fact]
    public void NumberZero() => Assert.False(HappyNumber.Run(0));
  }
}