using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_CW
{
    //ВНИМАТЕЛЬНО ПИСАТЬ ФУНКЦИЮ И СОБЛЮДАТЬ ПРАВИЛО ПОСТОЯННОГО ВОЗРАСТАНИЯ ИЛИ УБЫВАНИЯ И ПРОХОЖДЕНИЯ ЧЕРЕЗ 0!
    class Program
    {
        public static double f(double x)
        {
            return (x);
        }
        public static double function(double low, double high, double eps)
        {
            double z = (f(high) + f(low)) / 2;
            if ((high - low) >= eps)
            {
                //if(f(low)*f(z)>0)
                if(f(low)<0 && f(z)>0)
                {
                    z = function(low, z, eps);
                }
                if(f(z) < 0 && f(high) > 0)
                {
                    z = function(z, high, eps);
                }
            }
            return z;
        }
        public static void Print()
        {
            double eps = 0.01;
            Console.Write("Введите low: ");
            double low;
            while (!double.TryParse(Console.ReadLine(), out low))
            {
                Console.WriteLine("Вы ввели не число! Введите число!");
            }
            Console.Write("Введие high: ");
            double high;
            while (!double.TryParse(Console.ReadLine(), out high))
            {
                Console.WriteLine("Вы ввели не число! Введите число!");
            }
            if (low < high)
            {
                double x = function(low, high, eps);
                Console.Write("Ответ: {0}",x);
            }
            



        }

    }
}
