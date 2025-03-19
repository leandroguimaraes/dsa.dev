using DSA.Algorithms.Stacks;

namespace DSA.Tests.Algorithms.Stacks
{
  public class TestValidParentheses
  {
    [Fact]
    public void SingleParentheses() => Assert.True(ValidParentheses.Run("()"));

    [Fact]
    public void MultipleUngrouped() => Assert.True(ValidParentheses.Run("()[]{}"));

    [Fact]
    public void Enclosed() => Assert.True(ValidParentheses.Run("([])"));

    [Fact]
    public void MultipleEnclosed() => Assert.True(ValidParentheses.Run("([{}])"));

    [Fact]
    public void SingleInvalid() => Assert.False(ValidParentheses.Run("(]"));

    [Fact]
    public void InvalidEnclosed() => Assert.False(ValidParentheses.Run("([})"));

    [Fact]
    public void InvalidMultipleEnclosed() => Assert.False(ValidParentheses.Run("([{]})"));
  }
}