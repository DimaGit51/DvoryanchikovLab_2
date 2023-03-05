using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELPing
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
        static void Main(String[] args)
        {
            int n = helping.inputINT();
        }
    }
}
