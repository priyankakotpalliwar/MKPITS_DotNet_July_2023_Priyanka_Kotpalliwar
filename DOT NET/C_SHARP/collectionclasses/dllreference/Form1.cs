using calculatelibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dllreference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c=new Calculate();
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = c.Addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = "addition" + r;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = c.Substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = "substraction" + r;
        }
    }
}
