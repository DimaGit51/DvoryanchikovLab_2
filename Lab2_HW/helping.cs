using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_HW
{
    public class helping
    {
        static public int inputINT()
        {
            int x;
            Console.Write("Введите число ^int^: ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Вы ввели не число ^int^! Введите число: ");
            }
            return x;
        }
    }
}
