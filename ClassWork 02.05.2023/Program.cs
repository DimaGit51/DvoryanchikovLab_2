using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_02_05_2023
{
    public class TreeNode // Класс «Узел бинарного дерева»
    {
        private char info; // информационное поле
        private TreeNode left; // ссылка на левое поддерево
        private TreeNode right; // ссылка на правое поддерево
        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public TreeNode Right
        {
            get { return right; }
            set { right = value; }
        }
        public TreeNode() { } // конструкторы
        public TreeNode(char info)
        {
            Info = info;
        }
        public TreeNode(char info, TreeNode left, TreeNode right)
        {
            Info = info; Left = left; Right = right;
        }
    }

    public class BinaryTree // Класс «Бинарное дерево произвольного вида»
    {
        private TreeNode root; // ссылка на корень дерева
        public TreeNode Root // свойство, открывающее доступ к корню дерева
        {
            get { return root; }
            set { root = value; }
        }
        public BinaryTree() // инициализация пустого дерева
        {
            root = null;
        }

    }
    public class Program
    {
        static void Main()
        {

        }
    }
}