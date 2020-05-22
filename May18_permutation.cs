public class Solution
{
    public bool CheckInclusion(string s1, string s2) 
    {
        int s1sum = 0;
        int ns1 = s1.Length;
        int ns2 = s2.Length;
        for(int i=0;i<ns1;i++)
        {
            int c = s1[i];
            c=c-96;
            s1sum = s1sum + (c*c*c*c);
        }
        bool permutation = false;
        for(int i=0;i<(ns2-ns1+1);i++)
        {
            int sum =0;
            for(int j=i;j<(i+ns1);j++)
            {   
                int c = s2[j];
                c=c-96;
                sum = sum+(c*c*c*c);
            }
            if(sum == s1sum)
            {
                permutation = true;
                break;
            }
        }
        
        return permutation;
    }
}