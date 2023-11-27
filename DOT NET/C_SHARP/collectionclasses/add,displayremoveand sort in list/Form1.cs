using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_displayremoveand_sort_in_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> li = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            li.Sort();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string  so in li)
            {
                sb.Append("name "+so+"\n");
            }
            label2.Text = sb.ToString();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            li.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(li.Contains(textBox1.Text))
            {
                MessageBox.Show("found in list");
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("not in the in the list");
                textBox1.Clear();
                textBox1.Focus();
            }

        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            li.Insert(2, textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
