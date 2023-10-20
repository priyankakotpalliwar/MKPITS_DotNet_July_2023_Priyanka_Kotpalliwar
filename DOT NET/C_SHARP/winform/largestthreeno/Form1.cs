using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace largestthreeno
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
            int num3;
           string result=null;
            num1=Convert.ToInt32(textBox1.Text);
            num2=Convert.ToInt32(textBox2.Text);
            num3=Convert.ToInt32(textBox3.Text);
            if(num1 > num2 && num1>num3) {
                result = " num1 is grater";

            }
            else if (num2 > num3)
            {
                result = "num2 is greater";

            }
            else
            {
                result = "num 3 is greater";
            }
            label4.Text = result;

        }
    }
}
