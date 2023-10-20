using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quadrant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xcordinates=0;
            int ycordinates=0;
            xcordinates=Convert.ToInt32(textBox1.Text);
            ycordinates=Convert.ToInt32(textBox2.Text);
            string result=null;
            if(xcordinates>0 && ycordinates>0)
            {
                result = " I st Quadrant";

            }
            else if(xcordinates<0 && ycordinates>0) {
                result = "II nd Quadrant";
            }
            else if(ycordinates<0 && xcordinates<0) {
                result = "III rd quadrant";
            }
            else
            {
                result = "IV th Quadrant";
            }
            textBox3.Text = result;

        }
    }
}
