using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 費式數列計算機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int Fib(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return Fib(num - 1) + Fib(num - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = int.Parse(textBox1.Text);
            //var result=Fib(n);
            var x ="";

            for (int i = 0; i <= n; i++)
            {
                x += (Fib(i).ToString() + ",");
            }

            //MessageBox.Show(result.ToString());
            MessageBox.Show(x);
            //Console.WriteLine(n);
        }

    }
}
