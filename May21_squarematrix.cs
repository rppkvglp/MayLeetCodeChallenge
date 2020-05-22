public class Solution 
{ 
	public int CountSquares(int[][] matrix) 
	{
        int totalSquares = 0;
        int m = matrix.Length;
        int n = matrix[0].Length;
        
        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                if(i == 0 || j == 0) {
                    totalSquares += matrix[i][j];
                }
                else if(matrix[i][j] != 0) {
                    int top = matrix[i - 1][j];
                    int left = matrix[i][j - 1];
                    int diag = matrix[i - 1][j - 1];
                    
                    if(top != 0 && left != 0 && diag != 0)
                        matrix[i][j] = 1 + Math.Min(diag, Math.Min(top,left)); // min of all
                    
                    totalSquares += matrix[i][j];
                }
            }
        }
        
        return totalSquares;
    }
}