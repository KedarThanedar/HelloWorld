using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello1
{
    public class MathsOps
    {
        int a;
        int b;
        public MathsOps(int x,int y)
        {
                a=x;    
                b=y;
        }
        public MathsOps()
        {

        }
        public static int add(int a, int b)
        { 
            return a + b;        
        }

        public int multiply(int _a, int _b)
        {
            this.a = _a;
            this.b = _b;
            return a * b;  
        }
    }
}
