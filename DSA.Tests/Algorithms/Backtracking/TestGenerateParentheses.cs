using DSA.Algorithms.Backtracking;

namespace DSA.Tests.Algorithms.Backtracking
{
  public class TestGenerateParentheses
  {
    [Fact]
    public void Three() => Assert.Equal(["((()))", "(()())", "(())()", "()(())", "()()()"], GenerateParentheses.Run(3));

    [Fact]
    public void One() => Assert.Equal(["()"], GenerateParentheses.Run(1));
  }
}