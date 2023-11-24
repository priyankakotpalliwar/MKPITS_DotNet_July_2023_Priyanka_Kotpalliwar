using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace removeINWINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList arr=new ArrayList();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            foreach (object obj in arr) {
                sb.Append("number = "+obj.ToString()+"\n");
            }
            richTextBox1.Text=sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.Insert(0,textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arr.Remove(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            arr.RemoveAt(Convert.ToInt32(textBox2.Text));
        }
    }
}
