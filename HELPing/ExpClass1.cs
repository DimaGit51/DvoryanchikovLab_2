using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELPing
{
    internal class ExpClass1
    {
        static void Main()
        {
            int n = 4;
            int k = n;
            double result = 0;
            result = f(n, 0, n);

            Console.WriteLine(result);
        }
        static public double RecursionSumm23(int n, int k, double f)
        {
            if (n == 1) return f = 1;
            for (int i=0; i<n; i++)
            {
                for (double j=k+i; j<n+k+i; j+=1)
                {
                    f = f + (1 / j);
                    Console.WriteLine("{0} {1} {2}", k, i, j);
                }
            }
            k++;
            if (k<n*2) return RecursionSumm23(n, k, f);
            return f;
        }
        static public double f(int lv1, int sum, int n)
        {
            double s;
            int i;
 
            if (lv1 == 0) return 1.0 / sum;
            else
            {
                s = 0;
                for (i=1; i<=n; i++)
                {
                    s = s + f(lv1 - 1, sum + i, n);
                }
                return s;
            }
        }
    }
}
