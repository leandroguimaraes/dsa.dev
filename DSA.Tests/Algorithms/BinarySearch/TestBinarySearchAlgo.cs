using DSA.Algorithms.BinarySearch;

namespace DSA.Tests.Algorithms.BinarySearch
{
  public class TestBinarySearchAlgo
  {
    [Fact]
    public void ExistingTarget() => Assert.Equal(9, BinarySearchAlgo.Run([-1, 0, 3, 5, 9, 12], 9));

    [Fact]
    public void NonExistingTarget() => Assert.Equal(-1, BinarySearchAlgo.Run([-1, 0, 3, 5, 9, 12], 2));

    [Fact]
    public void EvenElements() => Assert.Equal(2, BinarySearchAlgo.Run([1, 2, 3, 4, 5, 6], 2));

    [Fact]
    public void OddElements() => Assert.Equal(5, BinarySearchAlgo.Run([1, 2, 3, 4, 5], 5));
  }
}