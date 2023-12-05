using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2darray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] num= new string [1,2];
        StringBuilder sb=new StringBuilder();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num[0, 0] = textBox1.Text;
            num[0,1]=textBox2.Text;
            sb.Append("album name - " + num[0, 0] + "\nsinger name - " + num[0, 1]);
            richTextBox1.Text = sb.ToString();

        }
    }
}
