public class StockSpanner 
{
    public ArrayList va;
    public ArrayList va1;
    public StockSpanner() 
    {
        va = new ArrayList();
        va1 = new ArrayList();
    }
    
    public int Next(int price) 
    {   
        va.Add(price);
        
        int n = va.Count;
        if(n <=0)
            return 0;
        if(n==1)
        {
            va1.Add(1);
            return 1;
        }
        int r =0;
        if(n>2)
        {
            r=r+1;
            int i=n-2;
            while(price>=(int)va[i])
            {
                if(i<0)
                    break;
                r=r+(int)va1[i];
                i=i-(int)va1[i];
                if(i<0)
                    break;
            }   
            
            //return 100;
        }
        else
        {
        
            for(int i=(n-1);i>=0;i--)
            {
                if(price>=(int)va[i])
                {
                    r=r+1;
                }
                else
                    break;
            }
        }                
        va1.Add(r);
        return r;
    }
}
