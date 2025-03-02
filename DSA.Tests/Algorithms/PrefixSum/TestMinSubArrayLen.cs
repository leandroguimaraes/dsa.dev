using DSA.Algorithms.PrefixSum;

namespace DSA.Tests.Algorithms.PrefixSum
{
    public class TestMinSubArrayLen
    {
        [Fact]
        public void Result2() => Assert.Equal(2, MinSubArrayLen.Run(7, [2, 3, 1, 2, 4, 3]));

        [Fact]
        public void Result1() => Assert.Equal(1, MinSubArrayLen.Run(4, [1, 4, 4]));

        [Fact]
        public void Result0() => Assert.Equal(0, MinSubArrayLen.Run(11, [1, 1, 1, 1, 1, 1, 1, 1]));

        [Fact]
        public void SingleElementArray() => Assert.Equal(1, MinSubArrayLen.Run(4, [5]));

        [Fact]
        public void SingleElementArrayResultEqual() => Assert.Equal(1, MinSubArrayLen.Run(4, [4]));

        [Fact]
        public void SingleElementArrayResult0() => Assert.Equal(0, MinSubArrayLen.Run(4, [1]));
    }
}