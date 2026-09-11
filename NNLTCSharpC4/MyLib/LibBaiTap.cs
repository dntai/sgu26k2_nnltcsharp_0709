namespace MyLib;

public class LibBaiTap
{
    /// <summary>
    /// Giải phương trình bậc 2
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <param name="x1"></param>
    /// <param name="x2"></param>
    /// <returns></returns>
    public static int GiaiPTBac2( 
        double a, double b, double c, 
        ref double x1, ref double x2)
    {
        int sn = 0;
        if (a == 0) 
        { 
            if (b == 0) 
            { 
                if (c == 0) 
                    sn = -1; 
                else 
                    sn = 0; 
            } 
            else 
            { 
                sn = 1; 
                x1 = -c / b; 
            } 
        } 
        else 
        { 
            double delta = b * b - 4 * a * c; 
            if (delta < 0) sn = 0; 
            else if (delta == 0) 
            { 
                sn = 1; 
                x1 = -b / (2 * a); 
            } 
            else 
            { 
                sn = 2; 
                x1 = (-b - Math.Sqrt(delta)) / (2 * a); 
                x2 = (-b + Math.Sqrt(delta)) / (2 * a); 
                if (x1 > x2) 
                { 
                    double tmp = x1; 
                    x1 = x2; 
                    x2 = tmp; 
                } 
            } 
        } 
        return sn;
    }
}
