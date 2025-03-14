using DSA.Algorithms.ArraysAndHashing;

namespace DSA.Tests.Algorithms.ArraysAndHashing
{
  public class TestContainsDuplicate
  {
    [Fact]
    public void SingleDuplicate() => Assert.True(ContainsDuplicate.Run([1, 2, 3, 1]));

    [Fact]
    public void NoDuplication() => Assert.False(ContainsDuplicate.Run([1, 2, 3, 4]));

    [Fact]
    public void MultipleDuplication() => Assert.True(ContainsDuplicate.Run([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
  }
}