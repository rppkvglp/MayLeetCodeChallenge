public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        int[] val = new int[26];
        
        for(int i=0;i<26;i++)
        {
            val[i] =0;
        }
        
        for(int i=0;i<magazine.Length;i++)
        {
            int c = magazine[i];
            val[c-97] = val[c-97] + 1;
        }
        
        bool res = true;
        
        for(int i=0;i<ransomNote.Length;i++)
        {
            int d = ransomNote[i];
            if(val[d-97]>0)
            {  
                val[d-97] = val[d-97] - 1;
            }
            else
            {
                res = false;
            }
        }
        
        return res;
        
    }
}