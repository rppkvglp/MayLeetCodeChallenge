public class Solution 
{
    public bool CheckStraightLine(int[][] coordinates) 
    {
        int n = coordinates.Length;
        bool sl = true;
        if(n==2)
            return true;
        float m = ((float)coordinates[1][1] - (float)coordinates[0][1])/((float)coordinates[1][0] - (float)coordinates[0][0]);
             
        if(m<0)
            m = (m*(-1));
        
        for(int i=0;i<n-1;i++)
        {
            float m1 =0;
            m1 = ((float)coordinates[i+1][1] - (float)coordinates[i][1])/((float)coordinates[i+1][0] - (float)coordinates[i][0]);
            if(m1<0)
                m1 = (m1*(-1));
            if(m != m1)
                sl =false;
        } 
        
        return sl;
    }
}