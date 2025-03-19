using DSA.Algorithms.Stacks;

namespace DSA.Tests.Algorithms.Stacks
{
  public class TestEvaluateReversePolishNotation
  {
    [Fact]
    public void TwoSimpleOperations() => Assert.Equal(9, EvaluateReversePolishNotation.Run(["2", "1", "+", "3", "*"]));

    [Fact]
    public void TwoGroupedOperations() => Assert.Equal(6, EvaluateReversePolishNotation.Run(["4", "13", "5", "/", "+"]));

    [Fact]
    public void MultipleOperations() => Assert.Equal(22, EvaluateReversePolishNotation.Run(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]));
  }
}