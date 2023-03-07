using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_HW
{
    class Program
    {
        public static string RecursionDecTo(int n, int k)
        {
            int z; int i;
            if (n == 0) z = 0;
            if (n / k > 0) { z = (n / k);  }

            else
            {
                z = 0;
                i = n % k;
            }
            return RecursionDecTo(n / k, k) + (n % k);
        }
        static void Main(String[] args)
        {
            Console.Write("Число для преобразования - ");
            int input_n = helping.inputINT();
            Console.Write("Система счисления - ");
            int input_k = helping.inputINT();
            String output_n = RecursionDecTo(input_n, input_k);
            Console.WriteLine(output_n);
        }

    }
}
