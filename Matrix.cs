public class Matrix
{
    public int FlipMatrixToMaximizeTopQuadrant(List<List<int>> matrix)
    {
        int total = 0;
        int n = matrix.Count / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                total += Math.Max(matrix[i][j], Math.Max(matrix[2 * n - i - 1][j], Math.Max(matrix[i][2 * n - j - 1], matrix[2 * n - i - 1][2 * n - j - 1])));
            }
        }

        return total;
    }
}