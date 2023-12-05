using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creating2darrayfor2rowsand2coloumbs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] details = new string[2, 2];
        StringBuilder sb = new StringBuilder();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            details[0,0]=textBox1.Text;
            details[0,1]=textBox2.Text;
            details[1,0]=textBox3.Text;
            details[1,1]=textBox4.Text;
            sb.Append("movie name - " + details[0,0]+"\nsong - " + details[0,1]);
            sb.Append("\nactor - " + details[1, 0] + "\nactoress - " + details[1, 1]);
            richTextBox1.Text = sb.ToString();

        }
    }
}
