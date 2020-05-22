public class Solution
{
    public bool IsPerfectSquare(int num) 
    {
        //bool chk = false;
        
        if(num == 1)
            return true;
        if(num<100)
        {
            for(int i=1;i<100;i++)
            {
                if((i*i) == num)
                    return true;
            }
            
            return false;
        }
        
        long left = 1;
        long right = num/10;
        right = right+1;
        
        while (left < right) 
        {
            long mid = left + (right - left) / 2;
            if((mid*mid) == num)
                return true;
            if ((mid * mid)>num)
            {
                right = mid;
            }   
            else 
            {
                left = mid + 1;
            }
        }   
    return false;
    }
    
}