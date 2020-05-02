public class Solution {
    public int NumJewelsInStones(string J, string S) 
    
    {   int c =0;
        for(int i=0;i<S.Length;i++)
        {
            if(chk(S[i],J))
                c=c+1;
        }
        return c;
        
    }
    
    public bool chk(char a, string j)
    {
        bool exist = false;
        for(int i=0;i<j.Length;i++)
        {
            if(a == j[i])
                exist = true;
        }
        
        return exist;
    }
}