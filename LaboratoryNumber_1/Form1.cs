using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaboratoryNumber_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        static public double RecursionSumm23(int n, int k, double result)
        {
            double returnResult = 0;
            if (n == 1) returnResult = 1;
            else
            {
                if (k < Math.Pow(n, n))
                {
                    string str1 = DecTo(k, n);
                    while ((str1.Length) < n) str1 = '0' + str1;
                    string str2 = "";
                    for (int i = 0; i < str1.Length; i++)
                    {
                        str2 += (double.Parse(str1[i].ToString()) + 1).ToString();
                    }
                    double SummaZnam = 0;
                    for (int i = 0; i < str2.Length; i++)
                    {
                        SummaZnam += double.Parse(str2[i].ToString());
                    }
                    result += 1 / SummaZnam;
                    k++;
                    result = RecursionSumm23(n, k, result);
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

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            string n = textBox_n.Text;
            int answerINT = inputINTmore0(n);
            int k = 0;
            double result = 0;
            if (answerINT == -1) { textBox_ErrorCode.Text = "Errors Code: -1"; textBox_Errors.Text = "Вы ввели не целое число! Введите целое число!"; }
            else if (answerINT == -2) { textBox_ErrorCode.Text = "Errors Code: -2"; textBox_Errors.Text = "Вы ввели целое отрицательное число! Введите целое положительное число!"; }
            else if (answerINT == -3) { textBox_ErrorCode.Text = "Errors Code: -3"; textBox_Errors.Text = "Переполнение Стека!"; }
            else {result = RecursionSumm23(answerINT, k, result); textBox_answer.Text = result.ToString(); }
           

        }
        static public int inputINTmore0(string n)
        {
            int x;
            if (!int.TryParse(n, out x)) x = -1;
            else if (x < 0) x = -2;
            else if (x > 5) x = -3;
            return x;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ErrorCode.Text = "Errors Code:";
            textBox_n.Text = "";
            textBox_Errors.Text = "";
            textBox_answer.Text = "";
        }
    }
}
