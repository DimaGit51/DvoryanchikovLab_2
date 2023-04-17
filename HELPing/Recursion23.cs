using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELPing
{
    internal class Recursion23
    {
        /*static void Main()
        {
            int n = 4;
            double result = 0;
            double[] mass = new double[n];
            int count = 1;

            for (int i = 0; i < n; i++)
            {
                mass[i] = 1;
            }

            RecursionSumm23(n, mass, result);
            Console.ReadKey();
        }


        static public void RecursionSumm23(int n, double[] mass, double result)
        {
            if (n == 1) result = 1;
            else
            {


                double sumn = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    sumn += mass[i];
                }
                result += 1 / sumn;



                if (sumn < n * n)
                {

                    int z = mass.Length - 1;
                    mass[z]++;
                    for (int j = z; j >= 1; j--)
                    {
                        if (mass[j] > n)
                        {
                            mass[j] = 1;
                            mass[j - 1]++;
                        }

                    }
                    RecursionSumm23(n, mass, result);
                }
                else
                {
                    Console.WriteLine("Result = {0}", result);
                }
            }
        }*/

    }
}