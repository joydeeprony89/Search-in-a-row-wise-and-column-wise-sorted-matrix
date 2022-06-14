using System;

namespace Search_in_a_row_wise_and_column_wise_sorted_matrix
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[][] matrix = new int[4][] { new int[] { 10, 20, 30, 40 }, new int[] { 15, 25, 35, 45 }, new int[] { 27, 29, 37, 48 }, new int[] { 32, 33, 39, 50 } };
      int[][] matrix = new int[1][] { new int[] { 1, 3 }  };
      Solution s = new Solution();
      var (i, j) = s.Search(matrix, 3);
      Console.WriteLine($"{i}/{j}");
    }
  }

  public class Solution
  {
    public (int , int) Search(int[][] matrix, int target)
    {
      if (matrix == null || matrix.Length == 0) return (-1, -1);

      int i = 0;
      int j = matrix[0].Length - 1;

      // As the array is sorted in rows and columns in Asc
      // We start with first row and last column
      // If the target value is smaller than at this place we need to search to the lesser element
      // where we will get lesser element ? either above the current row or in previous column
      // As we have started our search from the first row and last column , we will one get smaller no to the left of the current column
      // as we can not go above as we are started from the first row.
      // So basic idea here would be when we see an elemnt is greater than target we will shift to left
      // When we see a array no smaller than target will move to down.
      while(i >= 0 && j >= 0 && i < matrix.Length && j < matrix[0].Length)
      {
        if (target == matrix[i][j]) return (i, j);

        if (target < matrix[i][j]) j--;
        else i++;
      }

      return (-1, -1);
    }
  }
}
