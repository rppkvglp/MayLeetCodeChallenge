public class Solution {
    public int FirstUniqChar(string s) 
    {
        int[] v = new int[26];
        int[] v1 = new int[26];                
        int l = s.Length;
        
        for(int i =0;i<26;i++)
        {
            v[i] = 0;
            v1[i] = -1;
        }
        
        for(int i =0;i<l;i++)
        {
            int c = s[i];                   
            v[c-97] = v[c-97] + 1;;
            v1[c-97] = i;                             
        }
        
        int r = 1000000;
        for(int i =0;i<26;i++)
        {
            if(v[i] == 1)
            {
                if(v1[i]<r)
                    r=v1[i];                
            }
        }
        
        if(r == 1000000)
            return -1;
        return r;
    }
}