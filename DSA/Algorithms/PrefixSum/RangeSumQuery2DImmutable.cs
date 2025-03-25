namespace DSA.Algorithms.PrefixSum
{
  public class RangeSumQuery2DImmutable
  {
    private readonly int[][] sumMatrix;

    // https://leetcode.com/problems/range-sum-query-2d-immutable/description/
    // https://www.youtube.com/watch?v=KE8MQuwE2yA
    public RangeSumQuery2DImmutable(int[][] matrix)
    {
      var rowLength = matrix.Length + 1;
      var colLength = matrix[0].Length + 1;

      this.sumMatrix = new int[rowLength][];
      this.sumMatrix[0] = new int[colLength];

      for (int r = 1; r < rowLength; r++)
      {
        this.sumMatrix[r] = new int[colLength];
        for (int c = 1; c < colLength; c++)
        {
          this.sumMatrix[r][c] = matrix[r - 1][c - 1] + this.sumMatrix[r - 1][c] + this.sumMatrix[r][c - 1] - this.sumMatrix[r - 1][c - 1];
        }
      }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
      row1++;
      col1++;
      row2++;
      col2++;

      return this.sumMatrix[row2][col2] - this.sumMatrix[row1 - 1][col2] - this.sumMatrix[row2][col1 - 1] + this.sumMatrix[row1 - 1][col1 - 1];
    }
  }
}