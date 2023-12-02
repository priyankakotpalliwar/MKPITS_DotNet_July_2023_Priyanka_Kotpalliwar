using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_substract_multiply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculate c1 = new calculate();
        public int res = 0;
        private void button1_Click(object sender, EventArgs e)
        {
         int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            res= c1.addition(num1, num2);
            richTextBox1.Text = "addition of two number is" + res;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            res = c1.substract(num1, num2);
            richTextBox1.Text = "substract of two number is" + res;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            res = c1.multiply (num1, num2);
            richTextBox1.Text = "multiply of two number is" + res;
        }
    }
}
