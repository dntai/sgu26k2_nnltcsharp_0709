using MyLib; 
 
namespace Buoi01
{
    class GiaiPTBac2 
    { 
        public static void Main(string[] args) 
        { 
            double x1 = 0, x2 = 0; 
            int sn = LibBaiTap.GiaiPTBac2(1, 5, 6, ref x1, ref x2); 
    
            Console.WriteLine($"So nghiem: {sn}"); 
            Console.WriteLine($"x1 = {x1}"); 
            Console.WriteLine($"x2 = {x2}"); 
        } 
    } 
}
