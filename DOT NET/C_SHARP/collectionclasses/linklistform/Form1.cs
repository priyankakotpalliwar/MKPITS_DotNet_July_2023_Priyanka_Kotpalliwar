using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linklistform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList <int>li =new LinkedList<int>();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            li.AddLast(Convert.ToInt32( textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();


        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            li.AddFirst(Convert.ToInt32( textBox1.Text));   
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            li.Remove(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
