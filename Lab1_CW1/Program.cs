using System;
namespace Lab1_CW
{
    class Program
    {
        /*static void Main(String[] args)
        {
            Console.Write("Введите число X: ");
            uint x = uint.Parse(Console.ReadLine());
            proga(x);

        }*/
        static public void proga(uint x)
        {
            int count = 0;
            while (x != 0)
            {
                if ((x & 1) == 1)
                {
                    count++;
                }
                x = (x >> 1);
            }
            Console.WriteLine("Ответ: {0}", count);
        }
    }
}
