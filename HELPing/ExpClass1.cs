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
            int k = 0;
            double result=0;
            result = RecursionSumm23(n, k, result);
            Console.WriteLine(result);
            Console.ReadKey();
        }



        static public double RecursionSumm23(int n, int k, double result)
        {
            double returnResult = 0;
            if (n == 1)  returnResult = 1;
            else
            {
                if (k < Math.Pow(n,n))
                {
                    string str1 = DecTo(k, n);
                    while ((str1.Length) < n) str1 = '0'+str1;
                    string str2 = "";
                    for (int i = 0; i < str1.Length; i++)
                    {
                        str2 += (double.Parse(str1[i].ToString())+1).ToString();
                    }
                    double SummaZnam = 0;
                    for (int i = 0; i < str2.Length; i++)
                    {
                        SummaZnam+=double.Parse(str2[i].ToString());
                    }
                    k++;

                    result = RecursionSumm23(n, k, result);
                    result += 1 / SummaZnam;
                    Console.WriteLine(result);

                    returnResult = result;
                }
                else returnResult = result;
            }
            return returnResult;
        }

        static string DecTo(int n, int k)
        {
            if (n == 0)    //базовый сценарий - выход из рекурсии 
                return "0";
            if (n / k > 0)
                return DecTo(n / k, k) + (char)(n % k + '0');
            else
                return "" + (char)(n % k + '0');
        }
    }
}
