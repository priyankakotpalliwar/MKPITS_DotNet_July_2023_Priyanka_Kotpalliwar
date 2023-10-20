using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addition_multiplication_substrction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int add;

            num1=Convert.ToInt32(textBox1.Text);
            num2=Convert.ToInt32(textBox2.Text);
            add = num1 + num2;
            label3.Text = "result" + add;

        }
        
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            int num1;
            int num2;
            

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            int sub = num1 - num2;
            label3.Text = "result" + sub;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int multiply;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            multiply = num1 * num2;
            label3.Text = "result" + multiply;
        }
    }
}
