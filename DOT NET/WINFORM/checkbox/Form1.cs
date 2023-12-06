using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bsal=Convert.ToInt32(textBox2.Text);
            float bonus= 0.40f * bsal;
            float totalsalary = bsal + bonus;
            string empname=Convert.ToString(textBox1.Text);
            if(checkBox1.Checked) 
            {
                richTextBox1.Text=empname+ "bonus "+bonus.ToString();
            }
            if(checkBox2.Checked) 
            {
                richTextBox1.Text=empname+"total salary "+ totalsalary.ToString();
            }

        }
    }
}
