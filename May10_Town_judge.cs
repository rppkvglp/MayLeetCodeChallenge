public class Solution 
{
    public int FindJudge(int N, int[][] trust) 
    {
        int[] t = new int[N+1];
        int n1 = trust.Length;
        t[0] =-1;
        for(int i=1;i<=N;i++)
        {
            t[i] = 0;
        }
        
        for(int i=0;i<n1;i++)
        {
            t[trust[i][1]] = t[trust[i][1]] + 1;
        }
        
        int tj =-1;
        for(int i=1;i<=N;i++)
        {
            if(t[i]==N-1)
            {
                tj = i;                                
            }
        }
       if(tj==-1)
           return -1;
        
        for(int j=0;j<n1;j++)
        {
                if(trust[j][0]==tj)
                    return -1;
        }
        
        return tj;
        
    }
}