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
            int n = 2;
            int k = n;
            double result = 0;
            result = RecursionSumm23(n, k, result);

            Console.WriteLine(result);
        }
        static public double RecursionSumm23(int n, int k, double f)
        {
            if (n == 1) return f = 1;
            for (int i=0; i<n; i++)
            {
                double z = k + i;
                for (int j=0; j<n; j++)
                {
                    f = f + (1 / z);
                    Console.WriteLine("{0} {1} {2}", k, i, z);
                    z += 1;
                }
            }
            k++;
            if (k<n*2) return RecursionSumm23(n, k, f);
            return f;
        }
    }
}
