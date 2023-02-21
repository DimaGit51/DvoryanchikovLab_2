using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_CW
{
    //ВНИМАТЕЛЬНО ПИСАТЬ ФУНКЦИЮ И СОБЛЮДАТЬ ПРАВИЛО ПОСТОЯННОГО ВОЗРАСТАНИЯ ИЛИ УБЫВАНИЯ И ПРОХОЖДЕНИЯ ЧЕРЕЗ 0!
    class Tibet
    {
        public static void function(int n, int A, int B, int C)
        {
            //2^n - 1
            if (n == 1)
            {
                Console.WriteLine("A -> B");
            }
        }
        public static void Main()
        {
            Console.Write("Введите кол-во дисков: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Вы ввели не число! Введите число!");
            }
            int A = 3;
            int B = 0;
            int C = 0;
            function(n, A, B, C);
        }

    }
}
