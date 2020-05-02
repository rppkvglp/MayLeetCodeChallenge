public class Solution {
    public int NumJewelsInStones(string J, string S) 
    
    {
        int[] val = new int[52];
        for(int i=0;i<52;i++)
        {
            val[i] =-1;
        }
        for(int i=0;i<J.Length;i++)
        {
            int c = J[i];
            if(c>=65 && c<=90)
            {
                val[c-65] = 0;
            }
            else
            {
                val[c-97+26] =0;
            }
        }
        
        int count =0;
        
        for(int i=0;i<S.Length;i++)
        {
            int c = S[i];
            if(c>=65 && c<=90)
            {
                if(val[c-65] == 0)
                {
                    count = count + 1;
                }
            }
            else
            {
                if(val[c-97+26] == 0)
                {
                    count = count + 1;
                }
            }
        }
        
        return count;
    
    }
}