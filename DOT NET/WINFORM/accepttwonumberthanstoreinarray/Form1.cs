using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accepttwonumberthanstoreinarray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] num = new int[5];
        int i = 0;
        int sum = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          


            if (i<5) 
            {
                num[i]=Convert.ToInt32(textBox1.Text);
                sum = sum + num[i];
                i++;
                textBox1.Clear();
                textBox1.Focus();
                if(i==5) 
                {
                    label3.Text = " sum of five number " + sum;
                }
            }
            else
            {
                label3.Text = "error";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
