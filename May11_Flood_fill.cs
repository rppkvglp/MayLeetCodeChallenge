public class Solution 
{
    public bool indexcheck(int cr,int cl,int nr,int nc)
    {
        if((cr>=nr)||(cl>=nc)||(cl<0)||(cr<0))
            return true;
        return false;
    }
        
    public void ff(int[][] i,int cr,int cl,int c,int sc,int nr,int nc,bool[,] f)
    {
        if(indexcheck(cr,cl,nr,nc))
            return;
        if(f[cr,cl] == true)
            return;
        if(i[cr][cl]==sc)
        {
            i[cr][cl] = c;
            f[cr,cl] = true;
            
            if((!(indexcheck(cr+1,cl,nr,nc))) && (i[cr+1][cl]==sc))
            {
                ff( i, cr+1, cl, c, sc, nr, nc,f);
            }
            if((!(indexcheck(cr,cl+1,nr,nc))) && (i[cr][cl+1]==sc))
            {
                ff( i, cr, cl+1, c, sc, nr, nc,f);
            }
            if((!(indexcheck(cr-1,cl,nr,nc))) && (i[cr-1][cl]==sc))
            {
                ff( i, cr-1, cl, c, sc, nr, nc,f);
            }
            if((!(indexcheck(cr,cl-1,nr,nc))) && (i[cr][cl-1]==sc))
            {
                ff( i, cr, cl-1, c, sc, nr, nc,f);
            }
        }
        else
            return;
    }
    
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) 
    {
        int nr = image.Length;
        int nc = image[0].Length;
        bool[,] filled = new bool[nr,nc];
        for(int i=0;i<nr;i++)
        {
            for(int j=0;j<nc;j++)
            {
                filled[i,j] = false;
            }
        }
        
        ff(image,sr,sc,newColor,image[sr][sc],nr,nc,filled);        
        return image;       
    }
}