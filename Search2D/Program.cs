/**
https://leetcode.com/problems/search-a-2d-matrix-ii/description/ 


**/

int[][] matrix = new int[][]
   {
        new int[] { 1, 4, 7, 11, 15 },
        new int[] { 2, 5, 8, 12, 19 },
        new int[] { 3, 6, 9, 16, 22 },
        new int[] { 10, 13, 14, 17, 24 },
        new int[] { 18, 21, 23, 26, 30 }
   };

int target = 5;
bool result = SearchMatrix(matrix, target);

Console.WriteLine(result); // Output: True

target = 20;
result = SearchMatrix(matrix, target);

Console.WriteLine(result); // Output: False

bool SearchMatrix(int[][] matrix, int target)
{
    // Check if the matrix is empty
    if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
    {
        return false;
    }

    int rowCount = matrix.Length;
    int colCount = matrix[0].Length;

    // Start from the top-right corner of the matrix
    int row = 0;
    int col = colCount - 1;

    // Traverse the matrix
    while (row < rowCount && col >= 0)
    {
        if (matrix[row][col] == target)
        {
            return true;
        }
        else if (matrix[row][col] > target)
        {
            // Move left
            col--;
        }
        else
        {
            // Move down
            row++;
        }

    }

    // Target not found
    return false; 




}