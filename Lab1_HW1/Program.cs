using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1_HW
{
    internal class Program
    {
        private Z_book[] z_books;
        public Z_book[] Z_books
        {
            get { return z_books; }
            set { z_books = value; }
        }
        public Program()
        {
            Z_books = new Z_book[4];
        }
        void Print(string name)
        {
            for (int i = 0; i < Z_books.Length; i++)
            {
                if(name== Z_books[i].Name)
                Console.WriteLine("{0}", Z_books[i].Phone);
            }
        }
        static void Main()
        {
            Z_book z1 = new Z_book("Ivanov", "+79277944366");
            Z_book z2 = new Z_book("Petrov", "+79277945556");
            Z_book z3 = new Z_book("Sidorov", "+79277774366");
            Z_book z4 = new Z_book("Antonov", "+79276664366");
            Program pr1 = new Program();
            pr1.Z_books[0] = z1; pr1.Z_books[1] = z2;
            pr1.Z_books[2] = z3; pr1.Z_books[3] = z4;
            Console.Write("Введите Имя: ");
            string name = Console.ReadLine();
            pr1.Print(name);
        }
    }
}
