public class Solution 
{ 
    public int MaxSubarraySumCircular(int[] A) 
    {        
        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        int c1 = 0;
        int c2 = 0;
        int sum = 0;
        for(int i = 0; i < A.Length; i++){
            c1 += A[i];
            max = Math.Max(max, c1);
            c1 = Math.Max(c1, 0);
            
            c2 += A[i];
            min = Math.Min(min, c2);
            c2 = Math.Min(c2, 0);
            
            sum += A[i];
        }
        
        return max < 0 ? max : Math.Max(max, sum - min);
    }    
}
