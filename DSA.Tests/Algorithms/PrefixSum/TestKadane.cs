using DSA.Algorithms.PrefixSum;

namespace DSA.Tests.Algorithms.PrefixSum
{
    public class TestKadane
    {
        [Fact]
        public void PositiveNumbers() => Assert.Equal(15, Kadane.Run([1, 2, 3, 4, 5]));

        [Fact]
        public void NegativeNumbers() => Assert.Equal(-1, Kadane.Run([-1, -2, -3, -4, -5]));

        [Fact]
        public void PositiveNegativeNumbers() => Assert.Equal(6, Kadane.Run([-2, 1, -3, 4, -1, 2, 1, -5, 4]));
    }
}