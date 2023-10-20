using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evenorodd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            string result=null;
            num=Convert.ToInt32(textBox1.Text);
            if(num%2==0)
            {
                result = "it is even number";
            }
            else
            {
                result = "it  is odd number";
            }
            textBox2.Text = result;
        }

    }
}
