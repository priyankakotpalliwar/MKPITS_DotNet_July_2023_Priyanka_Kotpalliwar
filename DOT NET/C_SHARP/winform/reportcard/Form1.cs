using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportcard
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maths;
            int physics;
            int chemistry;
            string Grade = null;
            maths=Convert.ToInt32(textBox1.Text);
            physics = Convert.ToInt32(textBox2.Text);
            chemistry = Convert.ToInt32(textBox3.Text);
            int total= maths+ physics+chemistry;
            label4.Text = "total" + total;

            int per = total / 3;
            label5.Text = "percentege is " + per;
            if(per>=75)
            {
                Grade = "A";
            }
            else if(per<75 && per>=60)
            {
                Grade = "B";
                
            }
            else if(per>=40 && per<60)
            {
                Grade = "C";
            }
            else if(per<40  &&per>35)
            {
                Grade = "D";
            }
            else
            {
                Grade = "FAIL";
            }
            label6.Text = " grade is " + Grade;

        }
    }
}
