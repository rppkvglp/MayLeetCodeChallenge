public class Solution {
    public int FindComplement(int num) 
    {
        long i =1;

        for(i=1;;i=i*2)
        {
            if(i>num)
                break;
        }

        int r = (int)i;
        
        return (r -1-num);
        
    }
}