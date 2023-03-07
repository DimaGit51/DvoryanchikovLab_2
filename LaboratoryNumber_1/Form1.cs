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
        static public double RecursionSumm23(int n, int k, double f)
        {
            if (n == 1) return f = 1;
            for (int i = 0; i < n; i++)
            {
                for (double j = k + i; j < n + k + i; j += 1)
                {
                    f = f + (1 / j);
                    Console.WriteLine("{0} {1} {2}", k, i, j);
                }
            }
            k++;
            if (k < n * 2) return RecursionSumm23(n, k, f);
            return f;
        }
    }
}
