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
        static public double sum(double n)
        {

            double sum = 0;
            int min = (int)n;
            int max = (int)(n * n);
            int k = 0;
            double[] mas = new double[(int)Math.Pow(n, n)];
            for (int i = 0; i < mas.Length; i++)
            {
                if (k >= min)
                {
                    k = 0;
                    min++;
                }
                if (k + min > max)
                {
                    min = (int)n;
                }
                mas[i] = 1 / (double)(min + k);
                k++;
                sum += mas[i];
            }
            return sum;
        }
    }
}
