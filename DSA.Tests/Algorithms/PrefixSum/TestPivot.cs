using DSA.Algorithms.PrefixSum;

namespace DSA.Tests.Algorithms.PrefixSum
{
    public class TestPivot
    {
        [Fact]
        public void UpTo8() => Assert.Equal(6, Pivot.Run(8));

        [Fact]
        public void UpTo6() => Assert.Equal(-1, Pivot.Run(6));
    }
}